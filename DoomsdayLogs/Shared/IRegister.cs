using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public interface IRegister
    {
        public ProjectSettings SelectProjectOperation();

        UserControl GetLogTable(string logNamebyReference);

        Log GetLogSelected();

        public void DeleteLog();

        public void DeleteProject();
    }
}
