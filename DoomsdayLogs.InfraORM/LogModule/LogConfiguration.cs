using DoomsdayLogs.Domain.LogModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoomsdayLogs.Infra.ORM.LogModule
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("LogDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.LogName).HasColumnType("NVARCHAR(150)");
            builder.Property(p => p.LogDescription).HasColumnType("NVARCHAR(350)");
            builder.Property(p => p.LogDateTime).HasColumnType("DATETIME");
            builder.Property(p => p.LogLine).HasColumnType("NVARCHAR(20)");
            builder.Property(p => p.LogMethodName).HasColumnType("NVARCHAR(150)");
            builder.Property(p => p.LogClassName).HasColumnType("NVARCHAR(200)");
            builder.Property(p => p.LogHelp).HasColumnType("NVARCHAR(350)");
            builder.Property(p => p.LogType).HasColumnType("NVARCHAR(50)");
            builder.Property(p => p.LogData).HasColumnType("NTEXT");
            builder.Property(p => p.ProjectId).HasColumnType("INT");

            builder.HasOne(c => c.Project);
        }
    }
}