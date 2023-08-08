using DoomsdayLogs.Tool.Domain.ProjectModule;
using System;
using System.Collections.Generic;

namespace DoomsdayLogs.Tool.Application
{
    public class ProjectAppService
    {
        ProjectRepositoryORM projectRepository;

        public ProjectAppService(ProjectRepositoryORM projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<Project> SelectAllProjects()
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

        public Project SelectByProjectId(int id)
        {
            try
            {
                Project projectSelected = projectRepository.SelectById(id);
                return projectSelected;
            }
            catch { return null; }
        }

        public Project SelectProjectByName(string projectName)
        {
            try
            {
                Project project = projectRepository.SelectByProjectName(projectName);
                return project;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void InsertProject(Project project)
        {
            try
            {
                projectRepository.Insert(project);
            }
            catch (Exception ex) { }
        }
    }
}
