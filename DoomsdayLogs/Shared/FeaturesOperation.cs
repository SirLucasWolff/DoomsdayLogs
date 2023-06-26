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
            logTable = new DataGridViewLog(logAppService);
            projectSettings = new ProjectSettings(projectAppService);
        }

        public UserControl GetLogTable()
        {
            Project project = projectAppService.SelectAllProjects().Find(x => x.ProjectName == ProjectSelected.ProjectName);

            List<Log> logs = logAppService.SelectAllLogs().FindAll(x => x.ProjectId == project.Id);

            logTable.UpdateRegisters(logs);

            return logTable;
        }

        public ProjectSettings SelectProjectOperation()
        {
            return projectSettings;
        }

        public Log GetLogSelected()
        {
            int id = logTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a log to see the informations", "Log selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            Log logSelected = logAppService.SelectLogById(id);

            return logSelected;
        }
    }
}
