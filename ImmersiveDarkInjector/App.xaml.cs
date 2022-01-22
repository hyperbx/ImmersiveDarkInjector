global using System;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Reflection;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Hardcodet.Wpf.TaskbarNotification;

namespace ImmersiveDarkInjector
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
	{
        public static Configuration Settings { get; } = new Configuration().Import();

		public static TaskbarIcon TaskbarIcon { get; set; }

        public static bool IsAdministrator { get; } = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		
		private void App_OnStartup(object sender, StartupEventArgs e)
		{
#if !DEBUG
            if (!Win32.IsW10OrGreater(17763))
            {
                MessageBox.Show
                (
                    "Only Windows 10 build 17763 or later is supported.",
                    "Unsupported Windows Version",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );

                Shutdown(-1);
            }
#endif

			CreateSystemTrayIcon();

            Task.Run(() =>
            {
                while (true)
				{
					bool IsWindowExcluded(IntPtr hWnd)
					{
						if (hWnd == Win32.GetShellWindow())
							return true;

						if (Settings.Exclusions.Count == 0)
							return false;

						try
						{
							if (Settings.Exclusions.Any(x => x.Name == Process.GetProcessById(Win32.GetWindowProcess(hWnd)).ProcessName && x.Enabled))
								return true;
                        }
                        catch (InvalidOperationException)
						{
                            /* We end up here if the user removes an exclusion whilst LINQ is checking the collection.
							   Instead of crashing, we'll just exclude the current foreground window. */
							return true;
						}

						return false;
					}

					if (Settings.InjectAllOpenWindows)
					{
						// Run through all open windows and inject immersive dark mode.
						Win32.EnumWindows
						(
							delegate (IntPtr hWnd, IntPtr param)
							{
								if (!IsWindowExcluded(hWnd))
									ImmersiveDarkMode.Initialise(hWnd, true);

								// Return true to continue iterating.
								return true;
							},

							IntPtr.Zero
						);
                    }
					else
					{
						IntPtr hWnd = Win32.GetForegroundWindow();

						// Initialise immersive dark mode for the current focused window.
						if (!IsWindowExcluded(hWnd))
							ImmersiveDarkMode.Initialise(hWnd, true);
					}
                    
                    // Sleep until next injection.
                    Thread.Sleep(Settings.InjectionRate);
                }
            });
        }

        private void CreateSystemTrayIcon()
		{
			TaskbarIcon = new()
			{
				ContextMenu    = Current.TryFindResource("TaskbarIconMenu") as ContextMenu,
                Icon           = ImmersiveDarkInjector.Properties.Resources.Icon,
				MenuActivation = PopupActivationMode.RightClick,
				ToolTipText    = "Immersive Dark Injector"
            };

#if !DEBUG
            if (!IsAdministrator && !Settings.HideAdminWarning)
            {
				TaskbarIcon.ShowBalloonTip
                (
                    "Immersive Dark Injector",
                    "Please restart as administrator to be able to inject to windows from elevated processes.",
                    BalloonIcon.Warning
                );
            }
#endif
        }

		private void TaskbarIcon_ContextMenu_Settings(object sender, RoutedEventArgs e)
			=> new Settings().Show();

		private void TaskbarIcon_ContextMenu_GitHub(object sender, RoutedEventArgs e)
			=> ProcessExtensions.StartWithDefaultProgram("https://github.com/HyperBE32/ImmersiveDarkInjector");

		private void TaskbarIcon_ContextMenu_Exit(object sender, RoutedEventArgs e)
			=> Shutdown();
    }
}
