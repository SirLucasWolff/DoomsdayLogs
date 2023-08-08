using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Domain.ProjectModule;
using System.Collections.Generic;

namespace DoomsdayLogs.Tool
{
    public interface IRegister
    {
        Project SelectProjectByProjectName(string projectName);
        List<Log> SelectAllLogs();
        void InsertProject(Project project);
        void InsertLog(Log log);
        void DeleteLog(Log log);
    }
}
