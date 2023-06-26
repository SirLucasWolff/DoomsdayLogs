using DoomsdayLogs.DataBase.Shared;
using DoomsdayLogs.DataBuilderTest.LogModule;
using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Infra.ORM.LogModule;
using DoomsdayLogs.InfraORM;

namespace DoomsdayLogs.ORMTest.LogModule
{
    [TestClass]
    public class LogORM
    {
        LogOrmDAO logOrmDAO;

        [TestCleanup()]
        public void ClearTables()
        {
            //DataBaseController.DataBase("DELETE FROM LogDB WHERE Id IN (SELECT TOP 1 Id FROM LogDB ORDER BY Id DESC);");
        }

        public LogORM()
        {
            DoomsdayLogsDbContext doomsdayLogsDbContext = new DoomsdayLogsDbContext();
            logOrmDAO = new LogOrmDAO(doomsdayLogsDbContext);
        }

        [TestMethod]
        public void Should_Insert_Complete_log()
        {
            //Arrange

            LogDataBuilder logDataBuilder = new LogDataBuilder();

            Log log = logDataBuilder.GenerateCompleteLog();

            //Action

            logOrmDAO.Insert(log);

            //Assert

            Assert.AreEqual(log, logOrmDAO.SelectById(log.Id));
        }
    }
}