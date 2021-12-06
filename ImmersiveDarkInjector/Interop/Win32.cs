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
    }
}
