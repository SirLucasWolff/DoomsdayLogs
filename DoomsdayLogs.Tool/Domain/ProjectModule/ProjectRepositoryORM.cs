namespace DoomsdayLogs.Tool.Domain.ProjectModule
{
    public interface ProjectRepositoryORM : IRepository<Project, int>, IReadOnlyRepository<Project, int>
    {
        bool AlreadyExistTheProject(int id, string projectName);

        Project SelectByProjectName(string projectName);
    }
}
