using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Infra.ORM.BaseModule;
using DoomsdayLogs.InfraORM;

namespace DoomsdayLogs.Infra.ORM.LogModule
{
    public class LogOrmDAO : BaseRepository<Log, int>, LogRepositoryORM
    {
        DoomsdayLogsDbContext dbContext;

        public LogOrmDAO(DoomsdayLogsDbContext doomsdayLogsDbContext) : base(doomsdayLogsDbContext)
        {
            this.dbContext = doomsdayLogsDbContext;
        }

        public bool AlreadyExistTheLog(int id, string logName)
        {
            var ClientList = dbContext.LogDB.ToList();
            if (ClientList == null)
            {
                return false;
            }
            else
            {
                return ClientList.Exists(x => x.LogName == logName);
            }
        }
    }
}
