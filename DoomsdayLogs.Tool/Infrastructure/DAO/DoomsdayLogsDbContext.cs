using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Domain.ProjectModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;

namespace DoomsdayLogs.Tool.Infrastructure.DAO
{
    public class DoomsdayLogsDbContext : DbContext
    {
        private static readonly ILoggerFactory ConsoleLoggerFactory
              = LoggerFactory.Create(builder =>
              {
                  builder
                      .AddFilter((category, level) =>
                          category == DbLoggerCategory.Database.Command.Name
                          && level == LogLevel.Information)
                      .AddDebug();
              });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string registrySubKey = "SOFTWARE\\Doomsday Logs";

                string valueName = "DatabaseFilePath";

                object value = null;

                using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(registrySubKey))
                {
                    value = key.GetValue(valueName,null) + "\\DoomsdayLogsDB.mdf";
                }

                optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={value};Integrated Security=True");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoomsdayLogsDbContext).Assembly);
        }

        public DbSet<Log> LogDB { set; get; }
        public DbSet<Project> ProjectDB { set; get; }
    }
}
