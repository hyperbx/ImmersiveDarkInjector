namespace ImmersiveDarkInjector
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_General = new Noire.NoireGroupBox();
            this.CheckBox_HideAdminWarning = new Noire.NoireCheckBox();
            this.GroupBox_Injection = new Noire.NoireGroupBox();
            this.Label_Injection_Rate_Milliseconds = new System.Windows.Forms.Label();
            this.NumericUpDown_InjectionRate = new System.Windows.Forms.NumericUpDown();
            this.Label_Injection_Rate = new System.Windows.Forms.Label();
            this.Button_OK = new Noire.NoireButton();
            this.GroupBox_General.WorkingArea.SuspendLayout();
            this.GroupBox_General.SuspendLayout();
            this.GroupBox_Injection.WorkingArea.SuspendLayout();
            this.GroupBox_Injection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_InjectionRate)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_General
            // 
            this.GroupBox_General.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_General.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.GroupBox_General.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GroupBox_General.HeaderText = "General";
            this.GroupBox_General.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_General.Name = "GroupBox_General";
            this.GroupBox_General.Size = new System.Drawing.Size(309, 63);
            this.GroupBox_General.TabIndex = 0;
            this.GroupBox_General.TabStop = false;
            // 
            // GroupBox_General.WorkingArea
            // 
            this.GroupBox_General.WorkingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_General.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GroupBox_General.WorkingArea.Controls.Add(this.CheckBox_HideAdminWarning);
            this.GroupBox_General.WorkingArea.Location = new System.Drawing.Point(1, 25);
            this.GroupBox_General.WorkingArea.Name = "WorkingArea";
            this.GroupBox_General.WorkingArea.Size = new System.Drawing.Size(307, 37);
            this.GroupBox_General.WorkingArea.TabIndex = 0;
            // 
            // CheckBox_HideAdminWarning
            // 
            this.CheckBox_HideAdminWarning.AutoCheck = true;
            this.CheckBox_HideAdminWarning.AutoSize = true;
            this.CheckBox_HideAdminWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CheckBox_HideAdminWarning.CheckBoxBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CheckBox_HideAdminWarning.CheckBoxCheckedColour = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CheckBox_HideAdminWarning.CheckBoxIndeterminateColour = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CheckBox_HideAdminWarning.CheckBoxOutlineColour = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheckBox_HideAdminWarning.Checked = false;
            this.CheckBox_HideAdminWarning.CheckStyle = Noire.CheckBoxStyle.Check;
            this.CheckBox_HideAdminWarning.DisabledForeColour = System.Drawing.SystemColors.GrayText;
            this.CheckBox_HideAdminWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_HideAdminWarning.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckBox_HideAdminWarning.Indeterminate = false;
            this.CheckBox_HideAdminWarning.Label = "Hide administrator warning";
            this.CheckBox_HideAdminWarning.Location = new System.Drawing.Point(8, 8);
            this.CheckBox_HideAdminWarning.Name = "CheckBox_HideAdminWarning";
            this.CheckBox_HideAdminWarning.RightAlign = false;
            this.CheckBox_HideAdminWarning.Size = new System.Drawing.Size(170, 19);
            this.CheckBox_HideAdminWarning.TabIndex = 0;
            this.CheckBox_HideAdminWarning.ThreeState = false;
            this.CheckBox_HideAdminWarning.CheckedChanged += new System.EventHandler(this.CheckBox_HideAdminWarning_CheckedChanged);
            // 
            // GroupBox_Injection
            // 
            this.GroupBox_Injection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Injection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.GroupBox_Injection.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GroupBox_Injection.HeaderText = "Injection";
            this.GroupBox_Injection.Location = new System.Drawing.Point(12, 87);
            this.GroupBox_Injection.Name = "GroupBox_Injection";
            this.GroupBox_Injection.Size = new System.Drawing.Size(309, 63);
            this.GroupBox_Injection.TabIndex = 1;
            this.GroupBox_Injection.TabStop = false;
            // 
            // GroupBox_Injection.WorkingArea
            // 
            this.GroupBox_Injection.WorkingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Injection.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GroupBox_Injection.WorkingArea.Controls.Add(this.Label_Injection_Rate_Milliseconds);
            this.GroupBox_Injection.WorkingArea.Controls.Add(this.NumericUpDown_InjectionRate);
            this.GroupBox_Injection.WorkingArea.Controls.Add(this.Label_Injection_Rate);
            this.GroupBox_Injection.WorkingArea.Location = new System.Drawing.Point(1, 25);
            this.GroupBox_Injection.WorkingArea.Name = "WorkingArea";
            this.GroupBox_Injection.WorkingArea.Size = new System.Drawing.Size(307, 37);
            this.GroupBox_Injection.WorkingArea.TabIndex = 0;
            // 
            // Label_Injection_Rate_Milliseconds
            // 
            this.Label_Injection_Rate_Milliseconds.AutoSize = true;
            this.Label_Injection_Rate_Milliseconds.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Injection_Rate_Milliseconds.Location = new System.Drawing.Point(102, 12);
            this.Label_Injection_Rate_Milliseconds.Name = "Label_Injection_Rate_Milliseconds";
            this.Label_Injection_Rate_Milliseconds.Size = new System.Drawing.Size(23, 15);
            this.Label_Injection_Rate_Milliseconds.TabIndex = 2;
            this.Label_Injection_Rate_Milliseconds.Text = "ms";
            // 
            // NumericUpDown_InjectionRate
            // 
            this.NumericUpDown_InjectionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericUpDown_InjectionRate.Location = new System.Drawing.Point(46, 8);
            this.NumericUpDown_InjectionRate.Name = "NumericUpDown_InjectionRate";
            this.NumericUpDown_InjectionRate.Size = new System.Drawing.Size(54, 23);
            this.NumericUpDown_InjectionRate.TabIndex = 1;
            this.NumericUpDown_InjectionRate.ValueChanged += new System.EventHandler(this.NumericUpDown_InjectionRate_ValueChanged);
            // 
            // Label_Injection_Rate
            // 
            this.Label_Injection_Rate.AutoSize = true;
            this.Label_Injection_Rate.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Injection_Rate.Location = new System.Drawing.Point(7, 12);
            this.Label_Injection_Rate.Name = "Label_Injection_Rate";
            this.Label_Injection_Rate.Size = new System.Drawing.Size(33, 15);
            this.Label_Injection_Rate.TabIndex = 0;
            this.Label_Injection_Rate.Text = "Rate:";
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_OK.Checked = false;
            this.Button_OK.FlatAppearance.BorderSize = 0;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OK.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_OK.FormBackColour = System.Drawing.Color.Empty;
            this.Button_OK.Location = new System.Drawing.Point(201, 160);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(120, 32);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(333, 203);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_Injection);
            this.Controls.Add(this.GroupBox_General);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.GroupBox_General.WorkingArea.ResumeLayout(false);
            this.GroupBox_General.WorkingArea.PerformLayout();
            this.GroupBox_General.ResumeLayout(false);
            this.GroupBox_Injection.WorkingArea.ResumeLayout(false);
            this.GroupBox_Injection.WorkingArea.PerformLayout();
            this.GroupBox_Injection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_InjectionRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Noire.NoireGroupBox GroupBox_General;
        private Noire.NoireCheckBox CheckBox_HideAdminWarning;
        private Noire.NoireGroupBox GroupBox_Injection;
        private System.Windows.Forms.Label Label_Injection_Rate_Milliseconds;
        private System.Windows.Forms.NumericUpDown NumericUpDown_InjectionRate;
        private System.Windows.Forms.Label Label_Injection_Rate;
        private Noire.NoireButton Button_OK;
    }
}