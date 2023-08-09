using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public interface IRegister
    {
        public ProjectSettings SelectProjectOperation();

        UserControl GetLogTable(string logNamebyReference);

        Log GetLogSelected();

        public void DeleteLog();

        public List<Project> SelectAllProjects();

        public List<Log> SelectAllLogs();

        public void DeleteLogById(int id);
    }
}
