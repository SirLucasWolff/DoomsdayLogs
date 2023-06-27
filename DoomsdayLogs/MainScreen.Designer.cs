namespace DoomsdayLogs.WindowsForms
{
    partial class MainScreen
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            SearchText = new TextBox();
            SearchButton = new Button();
            FilterButton = new Button();
            SoldierSelectedImage = new PictureBox();
            BackButton = new Button();
            SoldierNameSelectedImage = new PictureBox();
            SoldierSelectedName = new Label();
            ProjectButton = new Button();
            ProjectNameLabel = new Label();
            ConfigurationButton = new Button();
            DataGridViewPanel = new Panel();
            OpenLogSelectedButton = new Button();
            ProjectNameSelected = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SoldierSelectedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SoldierNameSelectedImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.New_back_bar;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1173, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.New_back_bar_2;
            pictureBox2.Location = new Point(16, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1173, 535);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // SearchText
            // 
            SearchText.BackColor = Color.Black;
            SearchText.BorderStyle = BorderStyle.FixedSingle;
            SearchText.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchText.ForeColor = SystemColors.Window;
            SearchText.Location = new Point(302, 187);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(523, 25);
            SearchText.TabIndex = 3;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(134, 0, 27);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.FromArgb(134, 0, 27);
            SearchButton.Image = Properties.Resources.Search_image;
            SearchButton.Location = new Point(831, 179);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 38);
            SearchButton.TabIndex = 4;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(134, 0, 27);
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.ForeColor = Color.FromArgb(134, 0, 27);
            FilterButton.Image = Properties.Resources.Filter_image;
            FilterButton.Location = new Point(1097, 179);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(75, 38);
            FilterButton.TabIndex = 5;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // SoldierSelectedImage
            // 
            SoldierSelectedImage.BackColor = Color.FromArgb(134, 0, 27);
            SoldierSelectedImage.Location = new Point(539, 18);
            SoldierSelectedImage.Name = "SoldierSelectedImage";
            SoldierSelectedImage.Size = new Size(115, 108);
            SoldierSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            SoldierSelectedImage.TabIndex = 6;
            SoldierSelectedImage.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(134, 0, 27);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.FromArgb(134, 0, 27);
            BackButton.Image = Properties.Resources.Left;
            BackButton.Location = new Point(32, 29);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(31, 83);
            BackButton.TabIndex = 7;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SoldierNameSelectedImage
            // 
            SoldierNameSelectedImage.Image = Properties.Resources.New_back_bar_3;
            SoldierNameSelectedImage.Location = new Point(469, 132);
            SoldierNameSelectedImage.Name = "SoldierNameSelectedImage";
            SoldierNameSelectedImage.Size = new Size(250, 21);
            SoldierNameSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            SoldierNameSelectedImage.TabIndex = 8;
            SoldierNameSelectedImage.TabStop = false;
            // 
            // SoldierSelectedName
            // 
            SoldierSelectedName.AutoSize = true;
            SoldierSelectedName.BackColor = Color.FromArgb(134, 0, 27);
            SoldierSelectedName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SoldierSelectedName.Location = new Point(513, 135);
            SoldierSelectedName.Name = "SoldierSelectedName";
            SoldierSelectedName.Size = new Size(41, 16);
            SoldierSelectedName.TabIndex = 9;
            SoldierSelectedName.Text = "label1";
            // 
            // ProjectButton
            // 
            ProjectButton.BackColor = Color.FromArgb(134, 0, 27);
            ProjectButton.FlatStyle = FlatStyle.Flat;
            ProjectButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectButton.ForeColor = Color.FromArgb(134, 0, 27);
            ProjectButton.Image = Properties.Resources.Project_image;
            ProjectButton.Location = new Point(722, 48);
            ProjectButton.Name = "ProjectButton";
            ProjectButton.Size = new Size(293, 45);
            ProjectButton.TabIndex = 10;
            ProjectButton.UseVisualStyleBackColor = false;
            ProjectButton.Click += ProjectButton_Click;
            // 
            // ProjectNameLabel
            // 
            ProjectNameLabel.AutoSize = true;
            ProjectNameLabel.BackColor = Color.FromArgb(134, 0, 27);
            ProjectNameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectNameLabel.Location = new Point(152, 38);
            ProjectNameLabel.Name = "ProjectNameLabel";
            ProjectNameLabel.Size = new Size(293, 24);
            ProjectNameLabel.TabIndex = 11;
            ProjectNameLabel.Text = "PROJECT SELECTED NAME";
            // 
            // ConfigurationButton
            // 
            ConfigurationButton.BackColor = Color.FromArgb(134, 0, 27);
            ConfigurationButton.FlatStyle = FlatStyle.Flat;
            ConfigurationButton.ForeColor = Color.FromArgb(134, 0, 27);
            ConfigurationButton.Image = Properties.Resources.Configuration_image;
            ConfigurationButton.Location = new Point(1097, 48);
            ConfigurationButton.Name = "ConfigurationButton";
            ConfigurationButton.Size = new Size(60, 45);
            ConfigurationButton.TabIndex = 12;
            ConfigurationButton.UseVisualStyleBackColor = false;
            ConfigurationButton.Click += ConfigurationButton_Click;
            // 
            // DataGridViewPanel
            // 
            DataGridViewPanel.Location = new Point(69, 228);
            DataGridViewPanel.Name = "DataGridViewPanel";
            DataGridViewPanel.Size = new Size(1103, 462);
            DataGridViewPanel.TabIndex = 13;
            // 
            // OpenLogSelectedButton
            // 
            OpenLogSelectedButton.BackColor = Color.FromArgb(134, 0, 27);
            OpenLogSelectedButton.FlatStyle = FlatStyle.Flat;
            OpenLogSelectedButton.ForeColor = Color.FromArgb(134, 0, 27);
            OpenLogSelectedButton.Image = Properties.Resources.Right;
            OpenLogSelectedButton.Location = new Point(31, 228);
            OpenLogSelectedButton.Name = "OpenLogSelectedButton";
            OpenLogSelectedButton.Size = new Size(32, 462);
            OpenLogSelectedButton.TabIndex = 14;
            OpenLogSelectedButton.UseVisualStyleBackColor = false;
            OpenLogSelectedButton.Click += OpenLogSelectedButton_Click;
            // 
            // ProjectNameSelected
            // 
            ProjectNameSelected.AutoSize = true;
            ProjectNameSelected.BackColor = Color.FromArgb(134, 0, 27);
            ProjectNameSelected.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectNameSelected.Location = new Point(152, 75);
            ProjectNameSelected.Name = "ProjectNameSelected";
            ProjectNameSelected.Size = new Size(50, 18);
            ProjectNameSelected.TabIndex = 15;
            ProjectNameSelected.Text = "label1";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ProjectNameSelected);
            Controls.Add(OpenLogSelectedButton);
            Controls.Add(DataGridViewPanel);
            Controls.Add(ConfigurationButton);
            Controls.Add(ProjectNameLabel);
            Controls.Add(ProjectButton);
            Controls.Add(SoldierSelectedName);
            Controls.Add(SoldierNameSelectedImage);
            Controls.Add(BackButton);
            Controls.Add(SoldierSelectedImage);
            Controls.Add(FilterButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchText);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "MainScreen";
            Size = new Size(1205, 762);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SoldierSelectedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SoldierNameSelectedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox SearchText;
        private Button SearchButton;
        private Button FilterButton;
        private PictureBox SoldierSelectedImage;
        private Button BackButton;
        private PictureBox SoldierNameSelectedImage;
        private Label SoldierSelectedName;
        private Button ProjectButton;
        private Label ProjectNameLabel;
        private Button ConfigurationButton;
        private Panel DataGridViewPanel;
        private Button OpenLogSelectedButton;
        private Label ProjectNameSelected;
    }
}
