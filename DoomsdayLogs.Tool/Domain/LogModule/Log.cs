using DoomsdayLogs.Tool.Domain.ProjectModule;
using DoomsdayLogs.Tool.Domain.Shared;
using System;

namespace DoomsdayLogs.Tool.Domain.LogModule
{
    public class Log : BaseEntity<int>
    {
        public string LogName { get; set; }

        public string LogDescription { get; set; }

        public DateTime? LogDateTime { get; set; }

        public EnumLogType LogType { get; set; }

        public Byte[] LogTypeImage { get; set; }

        public string LogClassName { get; set; }

        public string LogDataName { get; set; }

        public string LogData { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public Log() { }
    }
}
