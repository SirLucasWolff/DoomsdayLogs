namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    partial class DetailsLogSelected
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
            LogNameLabel = new Label();
            LogDescriptionTextBox = new TextBox();
            CreateNotePadButton = new Button();
            LogTypeLabel = new Label();
            LogDateLabel = new Label();
            LogHelpLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            LogNameText = new Label();
            LogTypeText = new Label();
            LogDateText = new Label();
            LogHelpText = new LinkLabel();
            ChangeTextBoxButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // LogNameLabel
            // 
            LogNameLabel.AutoSize = true;
            LogNameLabel.BackColor = Color.FromArgb(134, 0, 27);
            LogNameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogNameLabel.ForeColor = Color.Black;
            LogNameLabel.Location = new Point(21, 22);
            LogNameLabel.Name = "LogNameLabel";
            LogNameLabel.Size = new Size(77, 24);
            LogNameLabel.TabIndex = 8;
            LogNameLabel.Text = "NAME:";
            // 
            // LogDescriptionTextBox
            // 
            LogDescriptionTextBox.BackColor = Color.FromArgb(134, 0, 27);
            LogDescriptionTextBox.BorderStyle = BorderStyle.None;
            LogDescriptionTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogDescriptionTextBox.ForeColor = SystemColors.Window;
            LogDescriptionTextBox.Location = new Point(20, 147);
            LogDescriptionTextBox.Multiline = true;
            LogDescriptionTextBox.Name = "LogDescriptionTextBox";
            LogDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            LogDescriptionTextBox.Size = new Size(1063, 225);
            LogDescriptionTextBox.TabIndex = 9;
            // 
            // CreateNotePadButton
            // 
            CreateNotePadButton.BackColor = Color.FromArgb(134, 0, 27);
            CreateNotePadButton.FlatStyle = FlatStyle.Flat;
            CreateNotePadButton.ForeColor = Color.FromArgb(134, 0, 27);
            CreateNotePadButton.Image = Properties.Resources.NotePad_image;
            CreateNotePadButton.Location = new Point(1029, 15);
            CreateNotePadButton.Name = "CreateNotePadButton";
            CreateNotePadButton.Size = new Size(55, 37);
            CreateNotePadButton.TabIndex = 10;
            CreateNotePadButton.UseVisualStyleBackColor = false;
            CreateNotePadButton.Click += CreateNotePadButton_Click;
            // 
            // LogTypeLabel
            // 
            LogTypeLabel.AutoSize = true;
            LogTypeLabel.BackColor = Color.FromArgb(134, 0, 27);
            LogTypeLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogTypeLabel.ForeColor = Color.Black;
            LogTypeLabel.Location = new Point(20, 65);
            LogTypeLabel.Name = "LogTypeLabel";
            LogTypeLabel.Size = new Size(71, 24);
            LogTypeLabel.TabIndex = 11;
            LogTypeLabel.Text = "TYPE:";
            // 
            // LogDateLabel
            // 
            LogDateLabel.AutoSize = true;
            LogDateLabel.BackColor = Color.FromArgb(134, 0, 27);
            LogDateLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogDateLabel.ForeColor = Color.Black;
            LogDateLabel.Location = new Point(20, 109);
            LogDateLabel.Name = "LogDateLabel";
            LogDateLabel.Size = new Size(72, 24);
            LogDateLabel.TabIndex = 12;
            LogDateLabel.Text = "DATE:";
            // 
            // LogHelpLabel
            // 
            LogHelpLabel.AutoSize = true;
            LogHelpLabel.BackColor = Color.FromArgb(134, 0, 27);
            LogHelpLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogHelpLabel.ForeColor = Color.Black;
            LogHelpLabel.Location = new Point(21, 418);
            LogHelpLabel.Name = "LogHelpLabel";
            LogHelpLabel.Size = new Size(72, 24);
            LogHelpLabel.TabIndex = 16;
            LogHelpLabel.Text = "HELP:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.New_back_bar;
            pictureBox1.Location = new Point(17, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1006, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.New_back_bar;
            pictureBox2.Location = new Point(17, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1067, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.New_back_bar;
            pictureBox3.Location = new Point(17, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1067, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.New_back_bar;
            pictureBox4.Location = new Point(19, 412);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1064, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // LogNameText
            // 
            LogNameText.AutoSize = true;
            LogNameText.BackColor = Color.FromArgb(134, 0, 27);
            LogNameText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogNameText.ForeColor = Color.White;
            LogNameText.Location = new Point(95, 25);
            LogNameText.Name = "LogNameText";
            LogNameText.Size = new Size(50, 18);
            LogNameText.TabIndex = 22;
            LogNameText.Text = "label1";
            // 
            // LogTypeText
            // 
            LogTypeText.AutoSize = true;
            LogTypeText.BackColor = Color.FromArgb(134, 0, 27);
            LogTypeText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogTypeText.ForeColor = Color.White;
            LogTypeText.Location = new Point(95, 67);
            LogTypeText.Name = "LogTypeText";
            LogTypeText.Size = new Size(50, 18);
            LogTypeText.TabIndex = 23;
            LogTypeText.Text = "label2";
            // 
            // LogDateText
            // 
            LogDateText.AutoSize = true;
            LogDateText.BackColor = Color.FromArgb(134, 0, 27);
            LogDateText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogDateText.ForeColor = Color.White;
            LogDateText.Location = new Point(95, 111);
            LogDateText.Name = "LogDateText";
            LogDateText.Size = new Size(50, 18);
            LogDateText.TabIndex = 24;
            LogDateText.Text = "label3";
            // 
            // LogHelpText
            // 
            LogHelpText.ActiveLinkColor = Color.FromArgb(134, 0, 27);
            LogHelpText.AutoSize = true;
            LogHelpText.BackColor = Color.FromArgb(134, 0, 27);
            LogHelpText.DisabledLinkColor = Color.FromArgb(134, 0, 27);
            LogHelpText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogHelpText.LinkColor = Color.LightCoral;
            LogHelpText.Location = new Point(95, 421);
            LogHelpText.Name = "LogHelpText";
            LogHelpText.Size = new Size(79, 18);
            LogHelpText.TabIndex = 25;
            LogHelpText.TabStop = true;
            LogHelpText.Text = "linkLabel1";
            // 
            // ChangeTextBoxButton
            // 
            ChangeTextBoxButton.Location = new Point(19, 378);
            ChangeTextBoxButton.Name = "ChangeTextBoxButton";
            ChangeTextBoxButton.Size = new Size(1065, 27);
            ChangeTextBoxButton.TabIndex = 26;
            ChangeTextBoxButton.Text = "See log datas";
            ChangeTextBoxButton.UseVisualStyleBackColor = true;
            ChangeTextBoxButton.Click += ChangeTextBoxButton_Click;
            // 
            // DetailsLogSelected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ChangeTextBoxButton);
            Controls.Add(LogHelpText);
            Controls.Add(LogDateText);
            Controls.Add(LogTypeText);
            Controls.Add(LogNameText);
            Controls.Add(LogHelpLabel);
            Controls.Add(LogDateLabel);
            Controls.Add(LogTypeLabel);
            Controls.Add(CreateNotePadButton);
            Controls.Add(LogDescriptionTextBox);
            Controls.Add(LogNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlDarkDark;
            Name = "DetailsLogSelected";
            Size = new Size(1140, 465);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private Label LogNameLabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label6;
        private PictureBox pictureBox8;
        private Label label7;
        private PictureBox pictureBox9;
        private LinkLabel LogHelpText;
        private TextBox LogDescriptionTextBox;
        private Button CreateNotePadButton;
        private Label LogTypeLabel;
        private Label LogDateLabel;
        private Label LogHelpLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label LogNameText;
        private Label LogTypeText;
        private Label LogDateText;
        private Button ChangeTextBoxButton;
    }
}
