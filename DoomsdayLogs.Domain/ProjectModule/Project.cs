using DoomsdayLogs.Domain.Shared;

namespace DoomsdayLogs.Domain.ProjectModule
{
    public class Project : BaseEntity<int>
    {
        public string? ProjectName { get; set; }

        public string? ProjectVersion { get; set; }

        public Project() { }
    }
}
