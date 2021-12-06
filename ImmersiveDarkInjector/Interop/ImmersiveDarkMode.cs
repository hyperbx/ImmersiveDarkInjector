using System;
using System.Runtime.InteropServices;

namespace ImmersiveDarkInjector
{
    internal class ImmersiveDarkMode
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hWnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        /// <summary>
        /// Initialises immersive dark mode for the input window handle in Desktop Window Manager.
        /// <para>This requires an application manifest that supports Windows 10 for OSVersion to return the correct build numbers.</para>
        /// </summary>
        /// <param name="hWnd">Window handle to apply immersive dark mode to.</param>
        /// <param name="enabled">Whether or not immersive dark mode should be enabled.</param>
        public static bool Initialise(IntPtr hWnd, bool enabled)
        {
            int useImmersiveDarkMode = enabled ? 1 : 0;

            if (IsW10OrGreater(17763))
            {
                int attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;

                if (IsW10OrGreater(18985))
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;

                return DwmSetWindowAttribute(hWnd, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        /// <summary>
        /// Checks if the returned OSVersion is greater than Windows 10.
        /// </summary>
        /// <param name="build">Windows 10 build number to check.</param>
        public static bool IsW10OrGreater(int build)
            => Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
    }
}
