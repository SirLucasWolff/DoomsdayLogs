using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Domain.ProjectModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;

namespace DoomsdayLogs.InfraORM
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
                string databaseFilePath = Registry.GetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Doomsday Logs", "DatabaseFilePath", null) + "\\DoomsdayLogsDB.mdf";

                optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True");
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