using DoomsdayLogs.Application.LogModule;
using DoomsdayLogs.Application.ProjectModule;
using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.WindowsForms.Shared;
using System.Configuration;

namespace DoomsdayLogs.WindowsForms.Features.ProjectModule
{
    public partial class ProjectSettings : UserControl
    {
        private readonly ProjectAppService projectAppService;

        public ProjectSettings(ProjectAppService projectAppService)
        {
            InitializeComponent();
            ProjectsDataGrid.ConfigGridChekered();
            ProjectsDataGrid.ConfigGridOnlyRead();
            ProjectsDataGrid.Columns.AddRange(GetColumns());
            this.projectAppService = projectAppService;
        }

        private DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ProjectName", HeaderText = "Project Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ProjectVersion", HeaderText = "Project Version"},
            };

            return colunas;
        }

        public int GetIdSelected()
        {
            return ProjectsDataGrid.SelectId<int>();
        }

        public void UpdateRegisters(List<Project> projects)
        {
            LoadTable(projects);
        }

        private void LoadTable(List<Project> projects)
        {
            ProjectsDataGrid.DataSource = projects;
        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {
            int id = GetIdSelected();

            Project projectSelected = projectAppService.SelectByProjectId(id);

            ProjectSelected.ProjectName = projectSelected.ProjectName;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["LastProjectSelected"].Value = ProjectSelected.ProjectName;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            MainScreen.Instance.SetProjectName();

            MainScreen.Instance.ConfigPanelRegisters();
        }

        private void ProjectSettings_Load(object sender, EventArgs e)
        {
            List<Project> projects = projectAppService.SelectAllProjects();

            UpdateRegisters(projects);
        }
    }
}
