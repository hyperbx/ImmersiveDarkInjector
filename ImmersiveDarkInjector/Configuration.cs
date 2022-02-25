using Newtonsoft.Json;
using System.IO;

namespace ImmersiveDarkInjector
{
    public class Configuration : INotifyPropertyChanged
    {
        private string _config = $"{AssemblyExtensions.GetAssemblyName()}.json";

        public BindingList<Exclusion> Exclusions { get; set; } = new();

        public int InjectionRate { get; set; } = 20;

        public bool IgnoreLowLatencyInjectionWarning { get; set; } = false;

        public bool InjectAllOpenWindows { get; set; } = true;

        public bool HideAdminWarning { get; set; } = false;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Configuration()
            => Exclusions.ListChanged += Exclusions_ListChanged;

        private void Exclusions_ListChanged(object? sender, ListChangedEventArgs e)
            => Export();

        public void OnPropertyChanged(PropertyChangedEventArgs e)
            => Export();

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