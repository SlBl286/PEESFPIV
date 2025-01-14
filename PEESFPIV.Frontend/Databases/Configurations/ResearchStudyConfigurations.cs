using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class ResearchStudyConfigurations : IEntityTypeConfiguration<ResearchStudy>
{
    public void Configure(EntityTypeBuilder<ResearchStudy> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<ResearchStudy> builder)
    {
        builder.ToTable("ResearchStudy");
        builder.HasKey(m => m.Id);
              builder.Property(m => m.VnTitle)
            .HasMaxLength(255);
        builder.Property(m => m.EnTitle)
            .HasMaxLength(255);
        builder.Property(m => m.EnDescription)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.VnDescription)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.Image)
            .HasMaxLength(255);
        builder.Property(m => m.Order);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");

    }
}