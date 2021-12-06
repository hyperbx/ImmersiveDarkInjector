using System;
using System.Windows.Forms;

namespace ImmersiveDarkInjector
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettingsUI();

            // Enable immersive dark mode for this form.
            ImmersiveDarkMode.Initialise(Handle, true);
        }

        private void LoadSettingsUI()
        {
            CheckBox_HideAdminWarning.Checked = Program.Settings.HideAdminWarning;
            NumericUpDown_InjectionRate.Value = Program.Settings.InjectionRate;
        }

        private void CheckBox_HideAdminWarning_CheckedChanged(object sender, EventArgs e)
            => Program.Settings.HideAdminWarning = CheckBox_HideAdminWarning.Checked;

        private void NumericUpDown_InjectionRate_ValueChanged(object sender, EventArgs e)
            => Program.Settings.InjectionRate = (int)NumericUpDown_InjectionRate.Value;

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Program.Settings.Export();
            Close();
        }
    }
}
