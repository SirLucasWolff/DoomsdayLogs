using DoomsdayLogs.Tool.Application;
using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Domain.ProjectModule;
using System.Collections.Generic;

namespace DoomsdayLogs.Tool
{
    public class FeaturesOperation: IRegister
    {
        private LogAppService logAppService;

        private ProjectAppService projectAppService;

        public FeaturesOperation(LogAppService logAppService, ProjectAppService projectAppService)
        {
            this.logAppService = logAppService;
            this.projectAppService = projectAppService;
        }

        public void DeleteLog(Log log)
        {
            logAppService.DeleteLog(log.Id);
        }

        public void InsertLog(Log log)
        {
            logAppService.InsertLog(log);
        }

        public void InsertProject(Project project)
        {
            projectAppService.InsertProject(project);
        }

        public List<Log> SelectAllLogs()
        {
            return logAppService.SelectAllLogs();
        }

        public Project SelectProjectByProjectName(string projectName)
        {
            try
            {
                return projectAppService.SelectProjectByName(projectName);
            }
            catch { }

            return null;
        }

        List<Log> IRegister.SelectAllLogs()
        {
            return logAppService.SelectAllLogs();
        }

        Project IRegister.SelectProjectByProjectName(string projectName)
        {
            return projectAppService.SelectProjectByName(projectName);
        }
    }
}
