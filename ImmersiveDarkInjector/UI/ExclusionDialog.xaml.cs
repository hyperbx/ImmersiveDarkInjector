using System.Windows;
using System.Windows.Controls;
using ModernWpf.Controls;

namespace ImmersiveDarkInjector
{
    /// <summary>
    /// Interaction logic for ExclusionDialog.xaml
    /// </summary>
    public partial class ExclusionDialog : ContentDialog
    {
		public static readonly DependencyProperty ResultProperty = DependencyProperty.Register
		(
			nameof(Result),
			typeof(string),
			typeof(ExclusionDialog),
			new PropertyMetadata("")
		);

		public string Result
		{
			get => (string)GetValue(ResultProperty);
			set => SetValue(ResultProperty, value);
		}

		public ExclusionDialog()
		{
			InitializeComponent();

			DataContext = this;
		}

		private void UI_TextBox_OnLoaded(object sender, RoutedEventArgs e)
			=> (sender as TextBox).Focus();
	}
}
