namespace ImmersiveDarkInjector
{
    public class ImmersiveDarkMode
    {
        /// <summary>
        /// Initialises immersive dark mode for the input window handle in Desktop Window Manager.
        /// <para>This requires an application manifest that supports Windows 10 for OSVersion to return the correct build numbers.</para>
        /// </summary>
        /// <param name="hWnd">Window handle to apply immersive dark mode to.</param>
        /// <param name="enabled">Whether or not immersive dark mode should be enabled.</param>
        public static bool Initialise(IntPtr hWnd, bool enabled)
        {
            int useImmersiveDarkMode = enabled ? 1 : 0;

            if (Win32.IsW10OrGreater(17763))
            {
                int attribute = Win32.DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;

                if (Win32.IsW10OrGreater(18985))
                    attribute = Win32.DWMWA_USE_IMMERSIVE_DARK_MODE;

                return Win32.DwmSetWindowAttribute(hWnd, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }
    }
}
