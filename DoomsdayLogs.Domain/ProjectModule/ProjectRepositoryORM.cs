namespace DoomsdayLogs.Domain.ProjectModule
{
    public interface ProjectRepositoryORM : IRepository<Project, int>, IReadOnlyRepository<Project, int>
    {
        public bool AlreadyExistTheProject(int id, string projectName);
    }
}
