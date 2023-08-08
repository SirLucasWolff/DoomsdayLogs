using System.Collections.Generic;

namespace DoomsdayLogs.Tool.Domain.LogModule
{
    public interface LogRepositoryORM : IRepository<Log, int>, IReadOnlyRepository<Log, int>
    {
        bool AlreadyExistTheLog(int id, string logName);

        List<Log> GetByReference(string name);

        Log SelectByLogName(string logName);
    }
}
