using System.Linq;
using System.Windows;
using ModernWpf.Controls;

namespace ImmersiveDarkInjector
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings
    {
        public Settings()
		{
			InitializeComponent();
		}

		private async void UI_Injection_Rate_OnValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		{
			if (sender.Value <= 1 && !App.Settings.IgnoreLowLatencyInjectionWarning)
			{
				CPUWarningDialog warning = new();
				var result = await warning.ShowAsync();

				if (result == ContentDialogResult.Primary)
				{
					// Never show this warning again.
					App.Settings.IgnoreLowLatencyInjectionWarning = true;
				}
				else
				{
					// Restore default injection rate.
					sender.Value = App.Settings.InjectionRate = 20;
				}
			}
		}

		private async void UI_Exclusions_Add_Click(object sender, RoutedEventArgs e)
		{
			ExclusionDialog exclusion = new();
			var result = await exclusion.ShowAsync();

			// Create new exclusion.
			if (result == ContentDialogResult.Primary && !string.IsNullOrEmpty(exclusion.Result))
				App.Settings.Exclusions.Add(new Exclusion(exclusion.Result));
		}

		private void UI_Exclusions_Remove_Click(object sender, RoutedEventArgs e)
			=> App.Settings.Exclusions.Remove(ExclusionList.SelectedItem as Exclusion);
	}
}
