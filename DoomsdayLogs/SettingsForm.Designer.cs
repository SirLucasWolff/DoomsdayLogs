namespace DoomsdayLogs.WindowsForms
{
    partial class SettingsForm
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
            SettingsPanel = new Panel();
            SuspendLayout();
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.Transparent;
            SettingsPanel.Dock = DockStyle.Fill;
            SettingsPanel.Location = new Point(0, 0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(476, 425);
            SettingsPanel.TabIndex = 0;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Doomsday_background_image;
            ClientSize = new Size(476, 425);
            Controls.Add(SettingsPanel);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsPanel;
    }
}