using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Infrastructure.DAO.BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoomsdayLogs.Tool.Infrastructure.DAO.LogModule
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

        public List<Log> GetByReference(string name)
        {
            try
            {
                char[] delimeters = new char[] { '%' };

                var nameFormated = name.Split(delimeters);

                string getNewName = null;

                foreach (var item in nameFormated)
                {
                    if (item != "")
                        getNewName = item;
                }

                List<Log> logSelected = dbContext.LogDB.ToList();

                if (getNewName == null)
                    return logSelected;

                bool result = false;

                List<Log> returLogs = new List<Log>();

                foreach (var movie in logSelected)
                {
                    result = movie.LogName.ToLower().Contains(getNewName);

                    if (result != false)
                        returLogs.Add(movie);
                }

                return returLogs;
            }
            catch (Exception ex)
            {
                return new List<Log>();
            }
        }

        public Log SelectByLogName(string logName)
        {
            try
            {
                Log log = dbContext.LogDB.ToList().Find(x => x.LogName == logName);
                return log;
            }
            catch (Exception ex)
            {
                return new Log();
            }
        }
    }
}
