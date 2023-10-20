using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Domain.ProjectModule;
using DoomsdayLogs.Tool.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace DoomsdayLogs.Tool
{
    public class DoomsdayLogs
    {
        private bool VerifyIfDatabaseConnectionExist()
        {
            object value = null;

            string registrySubKey = "SOFTWARE\\Doomsday Logs";

            string valueName = "DatabaseFilePath";

            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(registrySubKey))
            {
                value = key.GetValue(valueName, null) + "\\DoomsdayLogsDB.mdf";
            }

            if (File.Exists((string)value))
                return true;

            return false;
        }

        private (string CallerClassName, int CallerLineNumber) GetCallingClassInfo()
        {
            var stackTrace = new StackTrace();
            for (int i = 1; i < stackTrace.FrameCount; i++)
            {
                var callerFrame = stackTrace.GetFrame(i);
                var callerMethod = callerFrame.GetMethod();
                var callerType = callerMethod.DeclaringType;

                if (callerType != null && callerType.Namespace != typeof(DoomsdayLogs).Namespace)
                {
                    var callerLineNumber = callerFrame.GetFileLineNumber();
                    return (callerType.Name, callerLineNumber);
                }
            }

            return ("Unknown", -1);
        }

        private void LogProcess(string logName, string logDescription, object logData = null, EnumLogType enumLogType = 0)
        {
            if (VerifyIfDatabaseConnectionExist())
            {
                var entryAssembly = Assembly.GetEntryAssembly();

                Project projectOnDatabase = AutoFacBuilder.Register.SelectProjectByProjectName(entryAssembly.GetName().Name);

                if (projectOnDatabase == null)
                {
                    Project project = new Project();

                    project.ProjectName = entryAssembly.GetName().Name;
                    project.ProjectVersion = entryAssembly.GetName().Version.ToString();

                    AutoFacBuilder.Register.InsertProject(project);

                    projectOnDatabase = AutoFacBuilder.Register.SelectProjectByProjectName(project.ProjectName);
                }

                List<Log> AllLogsOnDatabase = AutoFacBuilder.Register.SelectAllLogs();

                if (projectOnDatabase != null && logName != "")
                {
                    if (AllLogsOnDatabase != null)
                    {
                        if (AllLogsOnDatabase.Exists(x => x.LogName == logName) == true)
                            return;
                    }

                    StackTrace stackTrace = new StackTrace();

                    var getLine = stackTrace.GetFrame(1);

                    Log log = new Log();

                    log.LogName = logName;
                    log.LogDescription = logDescription;
                    log.LogDateTime = DateTime.Now;

                    Byte[] logTyppeImage = null;

                    if (enumLogType == EnumLogType.Info)
                    {
                        log.LogType = EnumLogType.Info;
                        logTyppeImage = ConvertImageToBinaryLogType(GetImage(EnumLogType.Info));
                    }

                    if (enumLogType == EnumLogType.Warning)
                    {
                        log.LogType = EnumLogType.Warning;
                        logTyppeImage = ConvertImageToBinaryLogType(GetImage(EnumLogType.Warning));
                    }

                    if (enumLogType == EnumLogType.Error)
                    {
                        log.LogType = EnumLogType.Error;
                        logTyppeImage = ConvertImageToBinaryLogType(GetImage(EnumLogType.Error));
                    }

                    log.LogTypeImage = logTyppeImage;

                    log.LogClassName = GetCallingClassInfo().CallerClassName;

                    if (logData != null)
                    {
                        string result = "DataNameNotFound";

                        if (GetClassNameFromList(logData) != "Unknown" && result == "DataNameNotFound")
                            result = GetClassNameFromList(logData);

                        if (GetClassName(logData) != "Unknown" && result == "DataNameNotFound")
                            result = GetClassName(logData);

                        string logDataJson = JsonSerializer.Serialize(logData);

                        log.LogDataName = result;
                        log.LogData = logDataJson;
                    }

                    log.ProjectId = projectOnDatabase.Id;
                    log.Project = projectOnDatabase;

                    AutoFacBuilder.Register.InsertLog(log);
                }
            }
        }

        static string GetClassName(object obj)
        {
            if (obj != null)
            {
                Type objectType = obj.GetType();
                return objectType.Name;
            }

            return "Unknown";
        }

        static string GetClassNameFromList(object obj)
        {
            if (obj != null)
            {
                Type objectType = obj.GetType();

                if (objectType.IsGenericType)
                {
                    Type[] genericArguments = objectType.GetGenericArguments();
                    if (genericArguments.Length > 0)
                    {
                        Type containedType = genericArguments[0];
                        return containedType.Name;
                    }
                }
            }

            return "Unknown";
        }

        public void Info(string logName, string logDescription, object logData = null)
        {
            LogProcess(logName, logDescription, logData, EnumLogType.Info);
        }

        public void Warning(string logName, string logDescription, object logData = null)
        {
            LogProcess(logName, logDescription, logData, EnumLogType.Warning);
        }

        public void Error(string logName, string logDescription, object logData = null)
        {
            LogProcess(logName, logDescription, logData, EnumLogType.Error);
        }

        #region GetLogTypeImage

        private byte[] ConvertImageToBinaryLogType(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private System.Drawing.Image GetImage(EnumLogType enumLogType)
        {
            System.Drawing.Image image = null;

            if (enumLogType == EnumLogType.Info)
                image = Resources.White_Status;

            if (enumLogType == EnumLogType.Error)
                image = Resources.Red_Status;

            if (enumLogType == EnumLogType.Warning)
                image = Resources.Yellow_Status;

            return image;
        }

        #endregion
    }
}