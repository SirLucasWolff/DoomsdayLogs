﻿namespace DoomsdayLogs.Domain.LogModule
{
    public interface LogRepositoryORM : IRepository<Log, int>, IReadOnlyRepository<Log, int>
    {
        public bool AlreadyExistTheLog(int id, string logName);

        public List<Log> GetByReference(string name);

        public Log SelectByLogName(string logName);
    }
}
