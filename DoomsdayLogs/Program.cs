using Microsoft.Win32;
using System.Runtime.CompilerServices;

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

            string databaseFilePath = (string)Registry.GetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Doomsday Logs", "DatabaseFilePath", null) + "\\DoomsdayLogsDB.mdf";

            if (!File.Exists(databaseFilePath))
                MessageBox.Show("Database not found, please set a database using the chosen local path for 'DatabaseLocalPath' in Regisrty");
            else
                System.Windows.Forms.Application.Run(new DoomsdayLogsForm());
        }
    }
}