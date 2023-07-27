using DoomsdayLogs.Domain.LogModule;

namespace DoomsdayLogs.Application.LogModule
{
    public class LogAppService
    {
        LogRepositoryORM logRepository;

        public LogAppService (LogRepositoryORM logRepository)
        {
            this.logRepository = logRepository;
        }

        public List<Log>? SelectAllLogs()
        {
            try
            {
                List<Log> allLogsSelected = logRepository.SelectAll();
                return allLogsSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Log SelectLogById(int id)
        {
            try
            {
                Log logSelected = logRepository.SelectById(id);
                return logSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Log> SelectLogByReference(string logName)
        {
            try
            {
                List<Log> logSelected = logRepository.GetByReference(logName);
                return logSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Log SelectLogByName(string logName)
        {
            try
            {
                Log log = logRepository.SelectByLogName(logName);
                return log;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
