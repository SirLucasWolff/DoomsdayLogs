namespace DoomsdayLogs.WindowsForms.Features.ConfigurationModule
{
    partial class ConfigurationMenu
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
            NotePadOptions = new TabPage();
            DataNameCB = new CheckBox();
            SelectLocalPathLog = new Button();
            label5 = new Label();
            ProjectIdCB = new CheckBox();
            DataCB = new CheckBox();
            ClassNameCB = new CheckBox();
            TypeCB = new CheckBox();
            DateTimeCB = new CheckBox();
            DescriptionCB = new CheckBox();
            label1 = new Label();
            NameCB = new CheckBox();
            AboutTab = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label11 = new Label();
            TotalAvailableValue = new Label();
            TotalUsedValue = new Label();
            TotalGrantedValue = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            CheckKeyButton = new Button();
            APIKeyText = new TextBox();
            label6 = new Label();
            NotePadOptions.SuspendLayout();
            AboutTab.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // NotePadOptions
            // 
            NotePadOptions.BackgroundImage = Properties.Resources.Doomsday_background_image;
            NotePadOptions.Controls.Add(DataNameCB);
            NotePadOptions.Controls.Add(SelectLocalPathLog);
            NotePadOptions.Controls.Add(label5);
            NotePadOptions.Controls.Add(ProjectIdCB);
            NotePadOptions.Controls.Add(DataCB);
            NotePadOptions.Controls.Add(ClassNameCB);
            NotePadOptions.Controls.Add(TypeCB);
            NotePadOptions.Controls.Add(DateTimeCB);
            NotePadOptions.Controls.Add(DescriptionCB);
            NotePadOptions.Controls.Add(label1);
            NotePadOptions.Controls.Add(NameCB);
            NotePadOptions.Location = new Point(4, 24);
            NotePadOptions.Name = "NotePadOptions";
            NotePadOptions.Padding = new Padding(3);
            NotePadOptions.Size = new Size(486, 436);
            NotePadOptions.TabIndex = 2;
            NotePadOptions.Text = "NotePad Options";
            NotePadOptions.UseVisualStyleBackColor = true;
            NotePadOptions.Click += NotePadOptions_Click;
            // 
            // DataNameCB
            // 
            DataNameCB.AutoSize = true;
            DataNameCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataNameCB.ForeColor = SystemColors.ControlLightLight;
            DataNameCB.Location = new Point(277, 337);
            DataNameCB.Name = "DataNameCB";
            DataNameCB.Size = new Size(103, 22);
            DataNameCB.TabIndex = 13;
            DataNameCB.Text = "DataName";
            DataNameCB.UseVisualStyleBackColor = true;
            DataNameCB.CheckedChanged += DataNameCB_CheckedChanged;
            // 
            // SelectLocalPathLog
            // 
            SelectLocalPathLog.BackColor = Color.FromArgb(134, 0, 27);
            SelectLocalPathLog.FlatStyle = FlatStyle.Flat;
            SelectLocalPathLog.Image = Properties.Resources.NotePad_image;
            SelectLocalPathLog.Location = new Point(184, 97);
            SelectLocalPathLog.Name = "SelectLocalPathLog";
            SelectLocalPathLog.Size = new Size(93, 41);
            SelectLocalPathLog.TabIndex = 12;
            SelectLocalPathLog.UseVisualStyleBackColor = false;
            SelectLocalPathLog.Click += SelectLocalPathLog_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(71, 52);
            label5.Name = "label5";
            label5.Size = new Size(338, 24);
            label5.TabIndex = 11;
            label5.Text = "Select the file path to save the logs";
            // 
            // ProjectIdCB
            // 
            ProjectIdCB.AutoSize = true;
            ProjectIdCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectIdCB.ForeColor = SystemColors.ControlLightLight;
            ProjectIdCB.Location = new Point(277, 235);
            ProjectIdCB.Name = "ProjectIdCB";
            ProjectIdCB.Size = new Size(92, 22);
            ProjectIdCB.TabIndex = 10;
            ProjectIdCB.Text = "Project Id";
            ProjectIdCB.UseVisualStyleBackColor = true;
            ProjectIdCB.CheckedChanged += ProjectIdCB_CheckedChanged;
            // 
            // DataCB
            // 
            DataCB.AutoSize = true;
            DataCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataCB.ForeColor = SystemColors.ControlLightLight;
            DataCB.Location = new Point(277, 303);
            DataCB.Name = "DataCB";
            DataCB.Size = new Size(61, 22);
            DataCB.TabIndex = 9;
            DataCB.Text = "Data";
            DataCB.UseVisualStyleBackColor = true;
            DataCB.CheckedChanged += DataCB_CheckedChanged;
            // 
            // ClassNameCB
            // 
            ClassNameCB.AutoSize = true;
            ClassNameCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassNameCB.ForeColor = SystemColors.ControlLightLight;
            ClassNameCB.Location = new Point(277, 269);
            ClassNameCB.Name = "ClassNameCB";
            ClassNameCB.Size = new Size(110, 22);
            ClassNameCB.TabIndex = 6;
            ClassNameCB.Text = "Class name";
            ClassNameCB.UseVisualStyleBackColor = true;
            ClassNameCB.CheckedChanged += ClassNameCB_CheckedChanged;
            // 
            // TypeCB
            // 
            TypeCB.AutoSize = true;
            TypeCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeCB.ForeColor = SystemColors.ControlLight;
            TypeCB.Location = new Point(100, 337);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(60, 22);
            TypeCB.TabIndex = 4;
            TypeCB.Text = "Type";
            TypeCB.UseVisualStyleBackColor = true;
            TypeCB.CheckedChanged += TypeCB_CheckedChanged;
            // 
            // DateTimeCB
            // 
            DateTimeCB.AutoSize = true;
            DateTimeCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeCB.ForeColor = SystemColors.ButtonHighlight;
            DateTimeCB.Location = new Point(100, 303);
            DateTimeCB.Name = "DateTimeCB";
            DateTimeCB.Size = new Size(95, 22);
            DateTimeCB.TabIndex = 3;
            DateTimeCB.Text = "Date time";
            DateTimeCB.UseVisualStyleBackColor = true;
            DateTimeCB.CheckedChanged += DateTimeCB_CheckedChanged;
            // 
            // DescriptionCB
            // 
            DescriptionCB.AutoSize = true;
            DescriptionCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionCB.ForeColor = SystemColors.ButtonHighlight;
            DescriptionCB.Location = new Point(100, 269);
            DescriptionCB.Name = "DescriptionCB";
            DescriptionCB.Size = new Size(107, 22);
            DescriptionCB.TabIndex = 2;
            DescriptionCB.Text = "Description";
            DescriptionCB.UseVisualStyleBackColor = true;
            DescriptionCB.CheckedChanged += DescriptionCB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(73, 174);
            label1.Name = "label1";
            label1.Size = new Size(336, 24);
            label1.TabIndex = 1;
            label1.Text = "Select the visible datas in NotePad";
            // 
            // NameCB
            // 
            NameCB.AutoSize = true;
            NameCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameCB.ForeColor = SystemColors.ButtonHighlight;
            NameCB.Location = new Point(100, 235);
            NameCB.Name = "NameCB";
            NameCB.Size = new Size(69, 22);
            NameCB.TabIndex = 0;
            NameCB.Text = "Name";
            NameCB.UseVisualStyleBackColor = true;
            NameCB.CheckedChanged += NameCB_CheckedChanged;
            // 
            // AboutTab
            // 
            AboutTab.BackgroundImage = Properties.Resources.Doomsday_background_image;
            AboutTab.Controls.Add(label4);
            AboutTab.Controls.Add(label3);
            AboutTab.Controls.Add(label2);
            AboutTab.Location = new Point(4, 24);
            AboutTab.Name = "AboutTab";
            AboutTab.Padding = new Padding(3);
            AboutTab.Size = new Size(486, 436);
            AboutTab.TabIndex = 1;
            AboutTab.Text = "About";
            AboutTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(19, 365);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 4;
            label4.Text = "Version: 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(152, 184);
            label3.Name = "label3";
            label3.Size = new Size(162, 24);
            label3.TabIndex = 3;
            label3.Text = "Doomsday Logs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(106, 148);
            label2.Name = "label2";
            label2.Size = new Size(262, 24);
            label2.TabIndex = 2;
            label2.Text = "A SirLucasProductions tool";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AboutTab);
            tabControl1.Controls.Add(NotePadOptions);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(-5, 0);
            tabControl1.MaximumSize = new Size(494, 464);
            tabControl1.MinimumSize = new Size(494, 464);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(494, 464);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.Doomsday_background_image;
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(TotalAvailableValue);
            tabPage1.Controls.Add(TotalUsedValue);
            tabPage1.Controls.Add(TotalGrantedValue);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(CheckKeyButton);
            tabPage1.Controls.Add(APIKeyText);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(486, 436);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Open IA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(40, 210);
            label11.Name = "label11";
            label11.Size = new Size(413, 18);
            label11.TabIndex = 22;
            label11.Text = "_____________________________________________";
            // 
            // TotalAvailableValue
            // 
            TotalAvailableValue.AutoSize = true;
            TotalAvailableValue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAvailableValue.ForeColor = SystemColors.ControlLightLight;
            TotalAvailableValue.Location = new Point(157, 368);
            TotalAvailableValue.Name = "TotalAvailableValue";
            TotalAvailableValue.Size = new Size(0, 18);
            TotalAvailableValue.TabIndex = 21;
            // 
            // TotalUsedValue
            // 
            TotalUsedValue.AutoSize = true;
            TotalUsedValue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalUsedValue.ForeColor = SystemColors.ControlLightLight;
            TotalUsedValue.Location = new Point(131, 334);
            TotalUsedValue.Name = "TotalUsedValue";
            TotalUsedValue.Size = new Size(0, 18);
            TotalUsedValue.TabIndex = 20;
            // 
            // TotalGrantedValue
            // 
            TotalGrantedValue.AutoSize = true;
            TotalGrantedValue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalGrantedValue.ForeColor = SystemColors.ControlLightLight;
            TotalGrantedValue.Location = new Point(150, 301);
            TotalGrantedValue.Name = "TotalGrantedValue";
            TotalGrantedValue.Size = new Size(0, 18);
            TotalGrantedValue.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(40, 368);
            label10.Name = "label10";
            label10.Size = new Size(111, 18);
            label10.TabIndex = 18;
            label10.Text = "Total Available:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(40, 334);
            label9.Name = "label9";
            label9.Size = new Size(85, 18);
            label9.TabIndex = 17;
            label9.Text = "Total Used:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(40, 301);
            label8.Name = "label8";
            label8.Size = new Size(104, 18);
            label8.TabIndex = 16;
            label8.Text = "Total Granted:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(140, 253);
            label7.Name = "label7";
            label7.Size = new Size(186, 24);
            label7.TabIndex = 15;
            label7.Text = "Credits information";
            // 
            // CheckKeyButton
            // 
            CheckKeyButton.BackColor = Color.FromArgb(134, 0, 27);
            CheckKeyButton.FlatStyle = FlatStyle.Flat;
            CheckKeyButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckKeyButton.Location = new Point(169, 154);
            CheckKeyButton.Name = "CheckKeyButton";
            CheckKeyButton.Size = new Size(129, 41);
            CheckKeyButton.TabIndex = 14;
            CheckKeyButton.Text = "Check the Key";
            CheckKeyButton.UseVisualStyleBackColor = false;
            CheckKeyButton.Click += CheckKeyButton_Click;
            // 
            // APIKeyText
            // 
            APIKeyText.BackColor = Color.Black;
            APIKeyText.BorderStyle = BorderStyle.FixedSingle;
            APIKeyText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            APIKeyText.ForeColor = SystemColors.Window;
            APIKeyText.Location = new Point(40, 103);
            APIKeyText.Name = "APIKeyText";
            APIKeyText.Size = new Size(412, 21);
            APIKeyText.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(40, 55);
            label6.Name = "label6";
            label6.Size = new Size(411, 24);
            label6.TabIndex = 12;
            label6.Text = "Enter in the box your API Key from Open AI";
            // 
            // ConfigurationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(tabControl1);
            Name = "ConfigurationMenu";
            Size = new Size(492, 464);
            NotePadOptions.ResumeLayout(false);
            NotePadOptions.PerformLayout();
            AboutTab.ResumeLayout(false);
            AboutTab.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage NotePadOptions;
        private CheckBox ProjectIdCB;
        private CheckBox DataCB;
        private CheckBox ClassNameCB;
        private CheckBox TypeCB;
        private CheckBox DateTimeCB;
        private CheckBox DescriptionCB;
        private Label label1;
        private CheckBox NameCB;
        private TabPage AboutTab;
        private TabControl tabControl1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button SelectLocalPathLog;
        private CheckBox DataNameCB;
        private TabPage tabPage1;
        private Label label6;
        private Button CheckKeyButton;
        private TextBox APIKeyText;
        private Label label8;
        private Label label7;
        private Label TotalAvailableValue;
        private Label TotalUsedValue;
        private Label TotalGrantedValue;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}
