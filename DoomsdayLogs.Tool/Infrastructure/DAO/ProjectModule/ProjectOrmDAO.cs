using DoomsdayLogs.Tool.Domain.ProjectModule;
using DoomsdayLogs.Tool.Infrastructure.DAO.BaseModule;
using System.Linq;
using System;

namespace DoomsdayLogs.Tool.Infrastructure.DAO.ProjectModule
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

        public Project SelectByProjectName(string projectName)
        {
            try
            {
                Project project = dbContext.ProjectDB.ToList().Find(x => x.ProjectName == projectName);
                return project;
            }
            catch (Exception ex)
            {
                return new Project();
            }
        }
    }
}
