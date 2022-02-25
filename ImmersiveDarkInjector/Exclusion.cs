namespace ImmersiveDarkInjector
{
	public class Exclusion : INotifyPropertyChanged
	{
		public string Name { get; set; }

		public bool Enabled { get; set; }

		public event PropertyChangedEventHandler? PropertyChanged;

		public Exclusion(string name)
		{
			Name = name;
			Enabled = true;
		}
	}
}
