using DoomsdayLogs.DataBuilderTest.ProjectModule;
using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.Infra.ORM.ProjectModule;
using DoomsdayLogs.InfraORM;

namespace DoomsdayLogs.ORMTest.ProjectModule
{
    [TestClass]
    public class ProjectORM
    {
        ProjectOrmDAO projectOrmDAO;

        [TestCleanup()]
        public void ClearTables()
        {
            //DataBaseController.DataBase("DELETE FROM ProjectDB WHERE Id IN (SELECT TOP 1 Id FROM LogDB ORDER BY Id DESC);");
        }

        public ProjectORM()
        {
            DoomsdayLogsDbContext doomsdayLogsDbContext = new DoomsdayLogsDbContext();
            projectOrmDAO = new ProjectOrmDAO(doomsdayLogsDbContext);
        }

        [TestMethod]
        public void Should_Insert_Complete_project()
        {
            //Arrange

            ProjectDataBuilder projectDataBuilder = new ProjectDataBuilder();

            Project project = projectDataBuilder.GenerateCompleteProject();

            //Action

            projectOrmDAO.Insert(project);

            //Assert

            Assert.AreEqual(project, projectOrmDAO.SelectById(project.Id));
        }
    }
}
