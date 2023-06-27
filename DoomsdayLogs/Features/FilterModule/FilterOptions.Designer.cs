namespace DoomsdayLogs.WindowsForms.Features.FilterModule
{
    partial class FilterOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WarningRb = new RadioButton();
            ErrorRb = new RadioButton();
            InfoRb = new RadioButton();
            OkButton = new Button();
            SelectAllRb = new RadioButton();
            SuspendLayout();
            // 
            // WarningRb
            // 
            WarningRb.AutoSize = true;
            WarningRb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            WarningRb.ForeColor = SystemColors.ButtonHighlight;
            WarningRb.Location = new Point(164, 155);
            WarningRb.Name = "WarningRb";
            WarningRb.Size = new Size(105, 28);
            WarningRb.TabIndex = 0;
            WarningRb.TabStop = true;
            WarningRb.Text = "Warning";
            WarningRb.UseVisualStyleBackColor = true;
            // 
            // ErrorRb
            // 
            ErrorRb.AutoSize = true;
            ErrorRb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorRb.ForeColor = SystemColors.ControlLightLight;
            ErrorRb.Location = new Point(164, 215);
            ErrorRb.Name = "ErrorRb";
            ErrorRb.Size = new Size(75, 28);
            ErrorRb.TabIndex = 1;
            ErrorRb.TabStop = true;
            ErrorRb.Text = "Error";
            ErrorRb.UseVisualStyleBackColor = true;
            // 
            // InfoRb
            // 
            InfoRb.AutoSize = true;
            InfoRb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            InfoRb.ForeColor = SystemColors.ControlLightLight;
            InfoRb.Location = new Point(164, 272);
            InfoRb.Name = "InfoRb";
            InfoRb.Size = new Size(63, 28);
            InfoRb.TabIndex = 2;
            InfoRb.TabStop = true;
            InfoRb.Text = "Info";
            InfoRb.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.FromArgb(134, 0, 27);
            OkButton.FlatStyle = FlatStyle.Popup;
            OkButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OkButton.ForeColor = SystemColors.ActiveCaptionText;
            OkButton.Location = new Point(365, 378);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(95, 35);
            OkButton.TabIndex = 5;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // SelectAllRb
            // 
            SelectAllRb.AutoSize = true;
            SelectAllRb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SelectAllRb.ForeColor = SystemColors.ButtonHighlight;
            SelectAllRb.Location = new Point(164, 100);
            SelectAllRb.Name = "SelectAllRb";
            SelectAllRb.Size = new Size(113, 28);
            SelectAllRb.TabIndex = 6;
            SelectAllRb.TabStop = true;
            SelectAllRb.Text = "Select all";
            SelectAllRb.UseVisualStyleBackColor = true;
            // 
            // FilterOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(SelectAllRb);
            Controls.Add(OkButton);
            Controls.Add(InfoRb);
            Controls.Add(ErrorRb);
            Controls.Add(WarningRb);
            Name = "FilterOptions";
            Size = new Size(492, 464);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton WarningRb;
        private RadioButton ErrorRb;
        private RadioButton InfoRb;
        private Button OkButton;
        private RadioButton SelectAllRb;
    }
}
