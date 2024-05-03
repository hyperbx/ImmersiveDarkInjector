namespace ImmersiveDarkInjector
{
    public class AssemblyExtensions
    {
        /// <summary>
        /// Returns the assembly informational version from the entry assembly. 
        /// </summary>
        public static string GetInformationalVersion()
        {
            return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion
                .Split('+')[0];
        }

        /// <summary>
        /// Returns the current assembly name.
        /// </summary>
        public static string GetAssemblyName()
            => Assembly.GetEntryAssembly().GetName().Name;
    }
}
