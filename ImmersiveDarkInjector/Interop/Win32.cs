using Microsoft.Win32.TaskScheduler;
using System.Runtime.InteropServices;

namespace ImmersiveDarkInjector
{
    public class Win32
    {
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hWnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        public const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        public const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        /// <summary>
        /// Checks if the returned OSVersion is greater than Windows 10.
        /// </summary>
        /// <param name="build">Windows 10 build number to check.</param>
        public static bool IsW10OrGreater(int build)
            => Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;

        /// <summary>
        /// Returns the process ID of a window from its handle.
        /// </summary>
        /// <param name="hWnd">Window handle to get process ID from.</param>
        public static int GetWindowProcess(IntPtr hWnd)
        {
            GetWindowThreadProcessId(hWnd, out uint lpdwProcessId);

            return (int)lpdwProcessId;
        }

        public static bool TaskExists(string name)
        {
            using (var taskService = new TaskService())
                return taskService.GetTask(name) != null;
        }

        public static void CreateLogonTask(string name, string desc, string author, TaskRunLevel privileges = TaskRunLevel.Highest)
        {
            using (var taskService = new TaskService())
            {
                var def = taskService.NewTask();

                def.RegistrationInfo.Description = desc;
                def.RegistrationInfo.Author = author;
                def.Principal.RunLevel = privileges;
                def.Principal.UserId = Environment.UserName;

                var trigger = new LogonTrigger();
                def.Triggers.Add(trigger);

                def.Actions.Add(new ExecAction(Environment.ProcessPath));

                taskService.RootFolder.RegisterTaskDefinition(name, def);
            }
        }

        public static void RemoveTask(string name)
        {
            using (var taskService = new TaskService())
            {
                var task = taskService.GetTask(name);

                if (task == null)
                    return;

                taskService.RootFolder.DeleteTask(name);
            }
        }
    }
}
