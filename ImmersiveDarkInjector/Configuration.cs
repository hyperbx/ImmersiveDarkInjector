using Newtonsoft.Json;
using System.IO;

namespace ImmersiveDarkInjector
{
    internal class Configuration
    {
        private string _config = $"{Program.GetAssemblyName()}.json";

        public bool HideAdminWarning { get; set; } = false;

        public int InjectionRate { get; set; } = 25;

        public Configuration Export()
        {
            // Export current config.
            File.WriteAllText(_config, JsonConvert.SerializeObject(this, Formatting.Indented));

            // Return current config.
            return this;
        }

        public Configuration Import()
        {
            // Return deserialised object if the config exists.
            if (File.Exists(_config))
                return JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(_config));

            // Export from current config and return.
            return Export();
        }
    }
}
