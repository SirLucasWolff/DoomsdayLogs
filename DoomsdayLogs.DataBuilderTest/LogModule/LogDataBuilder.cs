using DoomsdayLogs.Domain.LogModule;
using Newtonsoft.Json;
using System.Drawing;

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

        public LogDataBuilder WithLogTypeImage()
        {
            Byte[] logTyppeImage = ConvertImageToBinaryLogType(GetImage(EnumLogType.Info));
            log.LogTypeImage = logTyppeImage;
            return this;
        }

        public LogDataBuilder WithLogClassName(string logClassName)
        {
            log.LogClassName = logClassName;
            return this;
        }

        public LogDataBuilder WithLogDataName(string dataName)
        {
            log.LogDataName = dataName;
            return this;
        }

        public LogDataBuilder WithLogData()
        {
            log.LogData = JsonConvert.SerializeObject(new LogDataTest());
            return this;
        }

        public LogDataBuilder WithProjectId()
        {
            log.ProjectId = 1;
            return this;
        }

        public Log GenerateCompleteLog()
        {
            return this.WithLogName("Daniel")
                .WithLogDescription("lalalallalalalalalala")
                .WithLogDateTime(DateTime.Now)
                .WithLogType(EnumLogType.Info)
                .WithLogTypeImage()
                .WithLogDataName("LULULULU")
                .WithLogClassName("testClassName")
                .WithLogData()
                .WithProjectId()
                .Build();
        }

        private class LogDataTest
        {
            public string? Name = "Maria";

            public int? Age = 50;
        }

        public Image GetImage(EnumLogType enumLogType)
        {
            string path = string.Empty;

            if (enumLogType == EnumLogType.Info)
                path = "C:\\Doomsday Logs\\DoomsdayLogs\\DoomsdayLogs\\Resources\\White Status.PNG";

            if (enumLogType == EnumLogType.Error)
                path = "C:\\Doomsday Logs\\DoomsdayLogs\\DoomsdayLogs\\Resources\\Red Status.PNG";

            if (enumLogType == EnumLogType.Warning)
                path = "C:\\Doomsday Logs\\DoomsdayLogs\\DoomsdayLogs\\Resources\\Yellow Status.PNG";

            var filePath = path;
            FileInfo fi = new FileInfo(filePath);
            Image tempImage = Image.FromFile(fi.FullName);
            return tempImage;
        }

        public byte[] ConvertImageToBinaryLogType(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
