using DoomsdayLogs.Tool.Domain.Shared;

namespace DoomsdayLogs.Tool.Domain.ProjectModule
{
    public class Project : BaseEntity<int>
    {
        public string ProjectName { get; set; }

        public string ProjectVersion { get; set; }

        public Project(string projectName, string projectVersion)
        {
            ProjectName = projectName;
            ProjectVersion = projectVersion;
        }

        public Project() { }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrWhiteSpace(ProjectName))
                ValidationResult = "The project name was null";

            if (string.IsNullOrWhiteSpace(ProjectVersion))
                ValidationResult = "The project version was null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }
    }
}
