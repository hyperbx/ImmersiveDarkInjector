using System;
using System.Runtime.InteropServices;

namespace ImmersiveDarkInjector
{
    internal class Win32
    {
        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr GetShellWindow();

        /// <summary>
        /// Checks if the returned OSVersion is greater than Windows 10.
        /// </summary>
        /// <param name="build">Windows 10 build number to check.</param>
        public static bool IsW10OrGreater(int build)
            => Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
    }
}
