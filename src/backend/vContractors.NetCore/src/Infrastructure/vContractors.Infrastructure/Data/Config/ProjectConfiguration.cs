using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vContractors.Domain.Entitties.Projects;

namespace vContractors.Infrastructure.Data.Config
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Title)
                        .IsRequired()
                        .HasMaxLength(256);
            builder.Property(p => p.Area)
                        .HasPrecision(18, 4);
            builder.ToTable(nameof(Project));
        }
    }
}
