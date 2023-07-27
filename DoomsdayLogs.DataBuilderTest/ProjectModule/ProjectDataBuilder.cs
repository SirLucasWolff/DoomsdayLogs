using DoomsdayLogs.Domain.ProjectModule;

namespace DoomsdayLogs.DataBuilderTest.ProjectModule
{
    public class ProjectDataBuilder
    {
        private Project project;

        public Project Build()
        {
            return project;
        }

        public ProjectDataBuilder()
        {
            project = new Project();
        }

        public ProjectDataBuilder WithProjectName(string name)
        {
            project.ProjectName = name;
            return this;
        }

        public ProjectDataBuilder WithProjectVersion(string version)
        {
            project.ProjectVersion = version;
            return this;
        }

        public Project GenerateCompleteProject()
        {
            return this.WithProjectName("testProjectDoomsday")
                .WithProjectVersion("6.6.6").Build();
        }
    }
}