namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    partial class OpenIAMessager
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
            TextPanel = new FlowLayoutPanel();
            LogDescriptionText = new Label();
            label3 = new Label();
            TextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TextPanel
            // 
            TextPanel.BackColor = Color.Transparent;
            TextPanel.BorderStyle = BorderStyle.FixedSingle;
            TextPanel.Controls.Add(LogDescriptionText);
            TextPanel.ForeColor = Color.Black;
            TextPanel.Location = new Point(12, 125);
            TextPanel.Name = "TextPanel";
            TextPanel.Size = new Size(960, 390);
            TextPanel.TabIndex = 30;
            // 
            // LogDescriptionText
            // 
            LogDescriptionText.AutoSize = true;
            LogDescriptionText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogDescriptionText.ForeColor = Color.White;
            LogDescriptionText.Location = new Point(3, 0);
            LogDescriptionText.Name = "LogDescriptionText";
            LogDescriptionText.Size = new Size(50, 18);
            LogDescriptionText.TabIndex = 0;
            LogDescriptionText.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(385, 53);
            label3.Name = "label3";
            label3.Size = new Size(175, 24);
            label3.TabIndex = 31;
            label3.Text = "Open AI message";
            // 
            // OpenIAMessager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Doomsday_background_image;
            ClientSize = new Size(984, 527);
            Controls.Add(label3);
            Controls.Add(TextPanel);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 566);
            MinimizeBox = false;
            MinimumSize = new Size(1000, 566);
            Name = "OpenIAMessager";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TextPanel.ResumeLayout(false);
            TextPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel TextPanel;
        private Label LogDescriptionText;
        private Label label3;
    }
}