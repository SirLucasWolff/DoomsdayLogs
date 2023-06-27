using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Domain.ProjectModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
                optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).UseSqlServer("Data Source=LUCASWOLFF\\SQLEXPRESS;Initial Catalog=DoomsdayLogsDB;Integrated Security=true;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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