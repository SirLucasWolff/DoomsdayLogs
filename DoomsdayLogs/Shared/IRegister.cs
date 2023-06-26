using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public interface IRegister
    {
        public ProjectSettings SelectProjectOperation();

        UserControl GetLogTable();

        Log GetLogSelected();
    }
}
