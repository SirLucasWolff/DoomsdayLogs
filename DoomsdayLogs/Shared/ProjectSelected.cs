using DoomsdayLogs.Domain.ProjectModule;
using System.Configuration;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public static class ProjectSelected
    {
        public static string? ProjectName = ConfigurationManager.AppSettings["LastProjectSelected"];

        public static string VerifyProjectName()
        {
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

            return ConfigurationManager.AppSettings["LastProjectSelected"];
        }
    }
}
