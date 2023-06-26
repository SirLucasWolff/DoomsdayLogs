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

        public string? LogLine { get; set; }

        public string? LogClassName { get; set; }

        public string? LogMethodName { get; set; }

        public string? LogHelp { get; set; }

        public string? LogData { get; set; }

        public int? ProjectId { get; set; }

        public Project Project { get; set; }

        public Log(string logName, string logDescription, DateTime logDateTime, EnumLogType logType, string? logLine, string? logClassName, string? logMethodName, string? logHelp, Project project)
        {
            LogName = logName;
            LogDescription = logDescription;
            LogDateTime = logDateTime;
            LogType = logType;
            LogLine = logLine;
            LogClassName = logClassName;
            LogMethodName = logMethodName;
            LogHelp = logHelp;
            Project = project;
            if (Project != null)
                ProjectId = project.Id;
        }

        public Log(string logName, string logDescription, DateTime logDateTime, EnumLogType logType, string logData, Project project)
        {
            LogName = logName;
            LogDescription = logDescription;
            LogDateTime = logDateTime;
            LogType = logType;
            LogData = logData;
            Project = project;
            if (Project != null)
                ProjectId = project.Id;
        }

        public Log() { }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrWhiteSpace(LogName))
                ValidationResult = "The log name was null";

            if (string.IsNullOrWhiteSpace(LogDescription))
                ValidationResult = "The log description was null";

            if (string.IsNullOrWhiteSpace(LogLine))
                ValidationResult = "The log line was null";

            if (string.IsNullOrWhiteSpace(LogClassName))
                ValidationResult = "The log class name was null";

            if (string.IsNullOrWhiteSpace(LogHelp))
                ValidationResult = "The log help was null";

            if (Project == null)
                ValidationResult = "The project was null";

            if (LogDateTime == null)
                ValidationResult = "The log date time was null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }
    }
}
