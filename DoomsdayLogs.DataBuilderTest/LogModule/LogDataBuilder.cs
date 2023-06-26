using DoomsdayLogs.Domain.LogModule;
using Newtonsoft.Json;

namespace DoomsdayLogs.DataBuilderTest.LogModule
{
    public class LogDataBuilder
    {
        private Log log;

        public Log Build()
        {
            return log;
        }

        public LogDataBuilder()
        {
            log = new Log();
        }

        public LogDataBuilder WithLogName(string name)
        {
            log.LogName = name;
            return this;
        }

        public LogDataBuilder WithLogDescription(string description)
        {
            log.LogDescription = description;
            return this;
        }

        public LogDataBuilder WithLogDateTime(DateTime date)
        {
            log.LogDateTime = date;
            return this;
        }

        public LogDataBuilder WithLogType(EnumLogType logType)
        {
            log.LogType = logType;
            return this;
        }

        public LogDataBuilder WithLogLine(string logLine)
        {
            log.LogLine = logLine;
            return this;
        }

        public LogDataBuilder WithLogClassName(string logClassName)
        {
            log.LogClassName = logClassName;
            return this;
        }

        public LogDataBuilder WithLogMethodName(string logMethodName)
        {
            log.LogMethodName = logMethodName;
            return this;
        }

        public LogDataBuilder WithLogHelp(string logHelp)
        {
            log.LogHelp = logHelp;
            return this;
        }

        public LogDataBuilder WithLogData()
        {
            log.LogData = JsonConvert.SerializeObject(new LogDataTest());
            return this;
        }

        public LogDataBuilder WithProjectId()
        {
            log.ProjectId = 2;
            return this;
        }

        public Log GenerateCompleteLog()
        {
            return this.WithLogName("testProject")
                .WithLogDescription("V8")
                .WithLogDateTime(DateTime.Now)
                .WithLogType(EnumLogType.Info)
                .WithLogLine("Line 25")
                .WithLogClassName("testClassName")
                .WithLogMethodName("testMethodName")
                .WithLogHelp("www.google.com.br")
                .WithLogData()
                .WithProjectId()
                .Build();
        }

        private class LogDataTest
        {
            public string? Name = "Maria";

            public int? Age = 50;
        }
    }
}
