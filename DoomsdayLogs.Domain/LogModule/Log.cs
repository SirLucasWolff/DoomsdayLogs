using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.Domain.Shared;

namespace DoomsdayLogs.Domain.LogModule
{
    public class Log : BaseEntity<int>
    {
        public string? LogName { get; set; }

        public string? LogDescription { get; set; }

        public DateTime? LogDateTime { get; set; }

        public EnumLogType? LogType { get; set; }

        public Byte[] LogTypeImage { get; set; }

        public string? LogClassName { get; set; }

        public string? LogDataName { get; set; }

        public string? LogData { get; set; }

        public int? ProjectId { get; set; }

        public Project Project { get; set; }

        public Log() { }
    }
}
