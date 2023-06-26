using System.Configuration;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public static class ProjectSelected
    {
        public static string? ProjectName = ConfigurationManager.AppSettings["LastProjectSelected"];
    }
}
