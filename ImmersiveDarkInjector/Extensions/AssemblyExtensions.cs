namespace ImmersiveDarkInjector
{
    public class AssemblyExtensions
    {
        /// <summary>
        /// Returns the assembly informational version from the entry assembly. 
        /// </summary>
        public static string GetInformationalVersion()
            => Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

        /// <summary>
        /// Returns the current assembly name.
        /// </summary>
        public static string GetAssemblyName()
            => Assembly.GetEntryAssembly().GetName().Name;
    }
}
