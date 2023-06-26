using DoomsdayLogs.Domain.ProjectModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoomsdayLogs.Infra.ORM.ProjectModule
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("ProjectDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ProjectName).HasColumnType("NVARCHAR(150)");
            builder.Property(p => p.ProjectVersion).HasColumnType("NVARCHAR(50)");
        }
    }
}
