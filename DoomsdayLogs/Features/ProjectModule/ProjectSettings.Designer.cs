namespace DoomsdayLogs.WindowsForms.Features.ProjectModule
{
    partial class ProjectSettings
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
            SelectProjectButton = new Button();
            ProjectsDataGrid = new DataGridView();
            RemoveProjectButton = new Button();
            RefreshProjectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProjectsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // SelectProjectButton
            // 
            SelectProjectButton.BackColor = Color.FromArgb(134, 0, 27);
            SelectProjectButton.FlatStyle = FlatStyle.Popup;
            SelectProjectButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectProjectButton.ForeColor = SystemColors.ActiveCaptionText;
            SelectProjectButton.Image = Properties.Resources.Select_Button;
            SelectProjectButton.Location = new Point(16, 377);
            SelectProjectButton.Name = "SelectProjectButton";
            SelectProjectButton.Size = new Size(142, 45);
            SelectProjectButton.TabIndex = 4;
            SelectProjectButton.UseVisualStyleBackColor = false;
            SelectProjectButton.Click += SelectProjectButton_Click;
            // 
            // ProjectsDataGrid
            // 
            ProjectsDataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            ProjectsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProjectsDataGrid.Location = new Point(0, 0);
            ProjectsDataGrid.Name = "ProjectsDataGrid";
            ProjectsDataGrid.RowTemplate.Height = 25;
            ProjectsDataGrid.Size = new Size(492, 371);
            ProjectsDataGrid.TabIndex = 5;
            // 
            // RemoveProjectButton
            // 
            RemoveProjectButton.BackColor = Color.FromArgb(134, 0, 27);
            RemoveProjectButton.FlatStyle = FlatStyle.Popup;
            RemoveProjectButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveProjectButton.ForeColor = SystemColors.ActiveCaptionText;
            RemoveProjectButton.Image = Properties.Resources.Remove_button;
            RemoveProjectButton.Location = new Point(164, 377);
            RemoveProjectButton.Name = "RemoveProjectButton";
            RemoveProjectButton.Size = new Size(142, 45);
            RemoveProjectButton.TabIndex = 6;
            RemoveProjectButton.UseVisualStyleBackColor = false;
            RemoveProjectButton.Click += RemoveProjectButton_Click;
            // 
            // RefreshProjectButton
            // 
            RefreshProjectButton.BackColor = Color.FromArgb(134, 0, 27);
            RefreshProjectButton.FlatStyle = FlatStyle.Popup;
            RefreshProjectButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshProjectButton.ForeColor = SystemColors.ActiveCaptionText;
            RefreshProjectButton.Image = Properties.Resources.Refresh_button;
            RefreshProjectButton.Location = new Point(312, 377);
            RefreshProjectButton.Name = "RefreshProjectButton";
            RefreshProjectButton.Size = new Size(142, 45);
            RefreshProjectButton.TabIndex = 7;
            RefreshProjectButton.UseVisualStyleBackColor = false;
            RefreshProjectButton.Click += RefreshProjectButton_Click;
            // 
            // ProjectSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(RefreshProjectButton);
            Controls.Add(RemoveProjectButton);
            Controls.Add(ProjectsDataGrid);
            Controls.Add(SelectProjectButton);
            Name = "ProjectSettings";
            Size = new Size(492, 464);
            Load += ProjectSettings_Load;
            ((System.ComponentModel.ISupportInitialize)ProjectsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button SelectProjectButton;
        private DataGridView ProjectsDataGrid;
        private Button RemoveProjectButton;
        private Button RefreshProjectButton;
    }
}
