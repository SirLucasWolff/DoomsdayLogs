namespace DoomsdayLogs
{
    partial class DoomsdayLogsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoomsdayLogsForm));
            MainPanel = new Panel();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1207, 723);
            MainPanel.TabIndex = 0;
            // 
            // DoomsdayLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = WindowsForms.Properties.Resources.Doomsday_background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1207, 723);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1223, 762);
            MinimizeBox = false;
            MinimumSize = new Size(1223, 762);
            Name = "DoomsdayLogsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doomsday Logs";
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
    }
}