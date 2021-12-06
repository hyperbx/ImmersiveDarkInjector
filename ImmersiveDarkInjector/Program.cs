using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmersiveDarkInjector
{
    internal static class Program
    {
        static NotifyIcon NotifyIcon { get; set; }

        static bool IsAdministrator { get; } = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Win32.IsW10OrGreater(17763))
            {
                MessageBox.Show
                (
                    "Only Windows 10 build 17763 or later is supported.",
                    "Unsupported Windows Version",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            CreateSystemTrayIcon();

            Task.Run(() =>
            {
                /* There could be many ways to optimise this task, but Windows
                   provides no convenient and/or efficient ways to do what I want.
                 
                   Here are my failed ideas;

                   1. Detect when a process was opened and get its window handle.

                      Why it failed: there's no way to detect when a process was
                      opened unless you use WMI, but by the time you receive the
                      event, it's too late and the window for that process has
                      already been shown and the effect is broken unless you move
                      or resize the window.

                   2. Check the current number of running processes and initialise
                      immersive dark mode if the number increases.

                      Why it failed: there's no efficient way to get the current
                      number of running processes - the standard way is to use
                      System.Diagnostics.Process.GetProcesses().Length which creates
                      an array just to get you the length.
                
                   3. Check if the immersive dark mode attributes are already set
                      on a window before re-applying it.
                
                      Why it failed: DwmGetWindowAttribute always returned true,
                      even for windows without immersive dark mode.
                
                   Letting the thread sleep every 25 milliseconds gives just enough
                   time for it to initialise on opening windows whilst keeping low
                   enough CPU usage. */

                // Current shell window handle - we want to avoid this.
                IntPtr shellWindowHandle = Win32.GetShellWindow();

                while (true)
                {
                    // Run through all open windows and inject immersive dark mode.
                    Win32.EnumWindows
                    (
                        delegate (IntPtr hWnd, IntPtr param)
                        {
                            // Skip shell window handle.
                            if (hWnd != shellWindowHandle)
                                ImmersiveDarkMode.Initialise(hWnd, true);

                            // Return true to continue iterating.
                            return true;
                        },

                        IntPtr.Zero
                    );

                    // Sleep to reduce CPU usage.
                    Thread.Sleep(25);
                }
            });

            Application.Run();
        }

        static void CreateSystemTrayIcon()
        {
            NotifyIcon = new NotifyIcon()
            {
                Text = "Immersive Dark Injector",
                Icon = Properties.Resources.Icon,
                Visible = true
            };

            NotifyIcon.ContextMenu = new ContextMenu
            (
                new[]
                {
                    new MenuItem("GitHub", NotifyIcon_ContextMenu_GitHub),
                    new MenuItem("Exit", NotifyIcon_ContextMenu_Exit)
                }
            );

            if (!IsAdministrator)
            {
                NotifyIcon.ShowBalloonTip
                (
                    8000,
                    "Immersive Dark Injector",
                    "Please restart as administrator to be able to hook to windows from elevated processes.",
                    ToolTipIcon.Warning
                );
            }
        }

        static void NotifyIcon_ContextMenu_GitHub(object sender, EventArgs e)
            => Process.Start("https://github.com/HyperBE32/ImmersiveDarkInjector");

        static void NotifyIcon_ContextMenu_Exit(object sender, EventArgs e)
        {
            // Set the tray icon to invisible so it doesn't linger.
            if (NotifyIcon != null)
                NotifyIcon.Visible = false;

            Application.Exit();
        }
    }
}