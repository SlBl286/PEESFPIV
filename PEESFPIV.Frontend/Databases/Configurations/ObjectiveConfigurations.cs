using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class ObjectiveConfigurations : IEntityTypeConfiguration<Objective>
{
    public void Configure(EntityTypeBuilder<Objective> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<Objective> builder)
    {
        builder.ToTable("Objective");
        builder.HasKey(m => m.Id);
              builder.Property(m => m.VnName)
            .HasMaxLength(255);
        builder.Property(m => m.EnName)
            .HasMaxLength(255);
        builder.Property(m => m.EnDescription)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.VnDescription)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");

    }
}