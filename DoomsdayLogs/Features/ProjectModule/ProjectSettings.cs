using DoomsdayLogs.Application.LogModule;
using DoomsdayLogs.Application.ProjectModule;
using DoomsdayLogs.Domain.LogModule;
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
                new DataGridViewTextBoxColumn { DataPropertyName = "ProjectName", HeaderText = "Project Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ProjectVersion", HeaderText = "Project Version"},
            };

            return colunas;
        }

        public object GetProjectNameSelected()
        {
            return ProjectsDataGrid.SelectTheValueObject();
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
            object obj = GetProjectNameSelected();

            if (obj == null)
            {
                MessageBox.Show("Select a project", "Project selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Project projectSelected = projectAppService.SelectProjectByName(obj.ToString());

            ProjectSelected.ProjectName = projectSelected.ProjectName;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["LastProjectSelected"].Value = ProjectSelected.ProjectName;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            MainScreen.Instance.SetProjectName();

            MainScreen.Instance.ConfigPanelRegisters(false);
        }

        private void ProjectSettings_Load(object sender, EventArgs e)
        {
            List<Project> projects = projectAppService.SelectAllProjects();

            UpdateRegisters(projects);
        }

        private void RemoveProjectButton_Click(object sender, EventArgs e)
        {
            object getProject = GetProjectNameSelected();

            if (getProject == null)
            {
                MessageBox.Show("Select a project to delete", "Project deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Project project = projectAppService.SelectProjectByName(getProject.ToString());

            List<Log> logs = AutoFacBuilder.Register.SelectAllLogs();

            foreach (Log log in logs)
            {
                if(log.Project != null)
                {
                    if (log.Project.ProjectName == project.ProjectName)
                    AutoFacBuilder.Register.DeleteLogById(log.Id);
                }
            }

            projectAppService.DeleteProject(project.Id);

            List<Project> projects = projectAppService.SelectAllProjects();

            UpdateRegisters(projects);

            List<Project> projectList = AutoFacBuilder.Register.SelectAllProjects();

            if (projectList.Count == 0)
                ProjectSelected.ProjectName = "";

            if (!projectList.Exists(x => x.ProjectName == ConfigurationManager.AppSettings["LastProjectSelected"]))
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["LastProjectSelected"].Value = "";

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }

            MainScreen.Instance.SetProjectName();

            MainScreen.Instance.ConfigPanelRegisters(false);
        }

        private void RefreshProjectButton_Click(object sender, EventArgs e)
        {
            List<Project> projects = projectAppService.SelectAllProjects();

            UpdateRegisters(projects);
        }
    }
}
