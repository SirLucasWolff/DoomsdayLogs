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
            ProjectIdCB = new CheckBox();
            DataCB = new CheckBox();
            HelpCB = new CheckBox();
            ClassNameCB = new CheckBox();
            LineCB = new CheckBox();
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
            NotePadOptions.SuspendLayout();
            AboutTab.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // NotePadOptions
            // 
            NotePadOptions.BackgroundImage = Properties.Resources.Doomsday_background_image;
            NotePadOptions.Controls.Add(ProjectIdCB);
            NotePadOptions.Controls.Add(DataCB);
            NotePadOptions.Controls.Add(HelpCB);
            NotePadOptions.Controls.Add(ClassNameCB);
            NotePadOptions.Controls.Add(LineCB);
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
            // ProjectIdCB
            // 
            ProjectIdCB.AutoSize = true;
            ProjectIdCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectIdCB.ForeColor = SystemColors.ControlLightLight;
            ProjectIdCB.Location = new Point(362, 70);
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
            DataCB.Location = new Point(205, 172);
            DataCB.Name = "DataCB";
            DataCB.Size = new Size(61, 22);
            DataCB.TabIndex = 9;
            DataCB.Text = "Data";
            DataCB.UseVisualStyleBackColor = true;
            DataCB.CheckedChanged += DataCB_CheckedChanged;
            // 
            // HelpCB
            // 
            HelpCB.AutoSize = true;
            HelpCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HelpCB.ForeColor = SystemColors.ControlLightLight;
            HelpCB.Location = new Point(205, 138);
            HelpCB.Name = "HelpCB";
            HelpCB.Size = new Size(59, 22);
            HelpCB.TabIndex = 8;
            HelpCB.Text = "Help";
            HelpCB.UseVisualStyleBackColor = true;
            HelpCB.CheckedChanged += HelpCB_CheckedChanged;
            // 
            // ClassNameCB
            // 
            ClassNameCB.AutoSize = true;
            ClassNameCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassNameCB.ForeColor = SystemColors.ControlLightLight;
            ClassNameCB.Location = new Point(205, 104);
            ClassNameCB.Name = "ClassNameCB";
            ClassNameCB.Size = new Size(110, 22);
            ClassNameCB.TabIndex = 6;
            ClassNameCB.Text = "Class name";
            ClassNameCB.UseVisualStyleBackColor = true;
            ClassNameCB.CheckedChanged += ClassNameCB_CheckedChanged;
            // 
            // LineCB
            // 
            LineCB.AutoSize = true;
            LineCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LineCB.ForeColor = SystemColors.ControlLightLight;
            LineCB.Location = new Point(205, 70);
            LineCB.Name = "LineCB";
            LineCB.Size = new Size(57, 22);
            LineCB.TabIndex = 5;
            LineCB.Text = "Line";
            LineCB.UseVisualStyleBackColor = true;
            LineCB.CheckedChanged += LineCB_CheckedChanged;
            // 
            // TypeCB
            // 
            TypeCB.AutoSize = true;
            TypeCB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeCB.ForeColor = SystemColors.ControlLight;
            TypeCB.Location = new Point(28, 172);
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
            DateTimeCB.Location = new Point(28, 138);
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
            DescriptionCB.Location = new Point(28, 104);
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
            label1.Location = new Point(76, 17);
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
            NameCB.Location = new Point(28, 70);
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
            label4.Text = "Version: 6.6.6";
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
            tabControl1.Location = new Point(-5, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(494, 464);
            tabControl1.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion

        private TabPage NotePadOptions;
        private CheckBox ProjectIdCB;
        private CheckBox DataCB;
        private CheckBox HelpCB;
        private CheckBox ClassNameCB;
        private CheckBox LineCB;
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
    }
}
