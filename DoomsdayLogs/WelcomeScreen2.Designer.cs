namespace DoomsdayLogs.WindowsForms
{
    partial class WelcomeScreen2
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
            MarceloSelectedButton = new Button();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            BackSoldierScreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // MarceloSelectedButton
            // 
            MarceloSelectedButton.BackColor = Color.Maroon;
            MarceloSelectedButton.FlatStyle = FlatStyle.Popup;
            MarceloSelectedButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MarceloSelectedButton.Location = new Point(513, 437);
            MarceloSelectedButton.Name = "MarceloSelectedButton";
            MarceloSelectedButton.Size = new Size(185, 35);
            MarceloSelectedButton.TabIndex = 21;
            MarceloSelectedButton.Text = "Marcelo The Iron Soldier";
            MarceloSelectedButton.UseVisualStyleBackColor = false;
            MarceloSelectedButton.Click += MarceloSelectedButton_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Select_a_soldier_text;
            pictureBox7.Location = new Point(91, 507);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1032, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Welcome_text;
            pictureBox6.Location = new Point(122, -86);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(962, 485);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Marcelo_face;
            pictureBox5.Location = new Point(513, 260);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(185, 171);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // BackSoldierScreen
            // 
            BackSoldierScreen.BackColor = Color.Maroon;
            BackSoldierScreen.FlatStyle = FlatStyle.Popup;
            BackSoldierScreen.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackSoldierScreen.Image = Properties.Resources.Left;
            BackSoldierScreen.Location = new Point(24, 662);
            BackSoldierScreen.Name = "BackSoldierScreen";
            BackSoldierScreen.Size = new Size(73, 35);
            BackSoldierScreen.TabIndex = 22;
            BackSoldierScreen.UseVisualStyleBackColor = false;
            BackSoldierScreen.Click += BackSoldierScreen_Click;
            // 
            // WelcomeScreen2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BackSoldierScreen);
            Controls.Add(MarceloSelectedButton);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Name = "WelcomeScreen2";
            Size = new Size(1185, 762);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button MarceloSelectedButton;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Button BackSoldierScreen;
    }
}
