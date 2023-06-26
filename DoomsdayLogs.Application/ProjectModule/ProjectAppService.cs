using DoomsdayLogs.Domain.ProjectModule;

namespace DoomsdayLogs.Application.ProjectModule
{
    public class ProjectAppService
    {
        ProjectRepositoryORM projectRepository;

        public ProjectAppService(ProjectRepositoryORM projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<Project>? SelectAllProjects()
        {
            try
            {
                List<Project> allProjectsSelected = projectRepository.SelectAll();
                return allProjectsSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Project? SelectByProjectId(int id)
        {
            try
            {
                Project projectSelected = projectRepository.SelectById(id);
                return projectSelected;
            }
            catch { return null; }
        }
    }
}