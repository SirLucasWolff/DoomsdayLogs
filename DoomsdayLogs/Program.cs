using Microsoft.Win32;
using System.Reflection;

namespace DoomsdayLogs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            VerifyRegistry();

            System.Windows.Forms.Application.Run(new DoomsdayLogsForm());
        }

        private static void VerifyRegistry()
        {
            string databaseFilePath = (string)Registry.GetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Doomsday Logs", "DatabaseFilePath", null);

            string solutionPath = GetSolutionPath() + "\\DoomsdayLogs.DataBase\\CurrentDataBase";

            if (databaseFilePath == null)
            {
                string baseKeyPath = @"SOFTWARE\Doomsday Logs";
                RegistryKey baseKey = Registry.LocalMachine.CreateSubKey(baseKeyPath);

                if (baseKey != null)
                { 
                    baseKey.SetValue("DatabaseFilePath", solutionPath);

                    baseKey.Close();
                }
            }
        }

        static string GetSolutionPath()
        {
            Assembly assembly = Assembly.GetEntryAssembly();

            string assemblyPath = assembly.Location;

            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

            string solutionPath = FindSolutionPath(assemblyDirectory);

            return solutionPath;
        }

        static string FindSolutionPath(string directory)
        {
            string solutionFile = Directory.GetFiles(directory, "*.sln").FirstOrDefault();

            if (!string.IsNullOrEmpty(solutionFile))
            {
                return Path.GetDirectoryName(solutionFile);
            }
            else
            {
                string parentDirectory = Directory.GetParent(directory)?.FullName;
                if (!string.IsNullOrEmpty(parentDirectory))
                {
                    return FindSolutionPath(parentDirectory);
                }
            }

            return null;
        }
    }
}