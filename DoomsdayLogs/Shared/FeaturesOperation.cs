using DoomsdayLogs.Application.LogModule;
using DoomsdayLogs.Application.ProjectModule;
using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.WindowsForms.Features.LogModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public class FeaturesOperation : IRegister
    {
        private LogAppService logAppService;

        private ProjectAppService projectAppService;

        private ProjectSettings projectSettings;

        private DataGridViewLog logTable;

        public FeaturesOperation(LogAppService logAppService, ProjectAppService projectAppService)
        {
            this.logAppService = logAppService;
            this.projectAppService = projectAppService;
            logTable = new DataGridViewLog();
            projectSettings = new ProjectSettings(projectAppService);
        }

        public UserControl GetLogTable(string referenceName)
        {
            Project project = null;

            if (ProjectSelected.ProjectName != "")
            {
                project = projectAppService.SelectAllProjects().Find(x => x.ProjectName == ProjectSelected.ProjectName);
            }
            else
            {
                if (project != null)
                {
                    project = projectAppService.SelectAllProjects().FirstOrDefault();

                    ProjectSelected.ProjectName = project.ProjectName;
                }
            }

            List<Log> logs = new List<Log>();

            if(project != null)
                logs = logAppService.SelectAllLogs().FindAll(x => x.ProjectId == project.Id);

            if (MainScreen.filterLogType != 0 && project != null)
            {
                logs = logAppService.SelectAllLogs().FindAll(x => x.LogType == MainScreen.filterLogType).FindAll(x => x.ProjectId == project.Id);
            }

            try
            {
                if (DateTime.TryParse(referenceName, out DateTime parsedDateTime))
                {
                    Console.WriteLine("The input date and time is valid: " + parsedDateTime.ToString("yyyy-MM-dd"));
                }
                else
                {
                    Console.WriteLine("The input date and time is invalid.");
                }
            }
            catch (Exception ex) { }

            if (referenceName != "" && project != null)
            {
                logs = logAppService.SelectLogByReference($"%{referenceName}%").FindAll(x => x.ProjectId == project.Id);
            }

            switch (FilterDateTime.filterDateTime)
            {
                case FilterDateTime.FilterDateTimeEnum.LastDateTime:
                    logs = logs.OrderByDescending(x => x.LogDateTime).ToList();
                    break;
                case FilterDateTime.FilterDateTimeEnum.OldDateTime:
                    logs = logs.OrderBy(x => x.LogDateTime).ToList();
                    break;
            }

            logTable.UpdateRegisters(logs);

            return logTable;
        }

        public ProjectSettings SelectProjectOperation()
        {
            return projectSettings;
        }

        public Log GetLogSelected()
        {
            object obj = logTable.GetObjectSelected();

            if (obj == null)
            {
                MessageBox.Show("Select a log to see the informations", "Log selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            Log log = logAppService.SelectLogByName(obj.ToString());

            return log;
        }

        public void DeleteLog()
        {
            object logSelected = logTable.GetObjectSelected();

            if(logSelected == null)
            {
                MessageBox.Show("Select a log to delete", "Log deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Log log = logAppService.SelectLogByName(logSelected.ToString());

            logAppService.DeleteLog(log.Id);
        }

        public List<Project> SelectAllProjects()
        {
            return projectAppService.SelectAllProjects();
        }

        public List<Log> SelectAllLogs()
        {
            return logAppService.SelectAllLogs();
        }

        public void DeleteLogById(int id)
        {
            logAppService.DeleteLog(id);
        }

        public List<Log> GetLogData()
        {
            List<string> logNames = logTable.GetLogData();

            List<Log> logs = new List<Log>();

            foreach(string logName in logNames)
            {
                logs.Add(logAppService.SelectLogByName(logName));
            }

            return logs;
        }
    }
}
