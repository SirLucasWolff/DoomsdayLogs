using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.Infra.ORM.BaseModule;
using DoomsdayLogs.InfraORM;

namespace DoomsdayLogs.Infra.ORM.ProjectModule
{
    public class ProjectOrmDAO : BaseRepository<Project, int>, ProjectRepositoryORM
    {
        DoomsdayLogsDbContext dbContext;

        public ProjectOrmDAO(DoomsdayLogsDbContext doomsdayLogsDbContext) : base(doomsdayLogsDbContext)
        {
            this.dbContext = doomsdayLogsDbContext;
        }

        public bool AlreadyExistTheProject(int id, string projectName)
        {
            var ProjectList = dbContext.ProjectDB.ToList();
            if (ProjectList == null)
            {
                return false;
            }
            else
            {
                return ProjectList.Exists(x => x.ProjectName == projectName);
            }
        }
    }
}
