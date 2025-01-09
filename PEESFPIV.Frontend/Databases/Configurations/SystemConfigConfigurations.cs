using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class SystemConfigConfigurations : IEntityTypeConfiguration<SystemConfig>
{
    public void Configure(EntityTypeBuilder<SystemConfig> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<SystemConfig> builder)
    {
        builder.ToTable("SystemConfig");
        builder.HasKey(m => m.Id);
              builder.Property(m => m.Code)
            .HasMaxLength(100);
        builder.Property(m => m.Name)
            .HasMaxLength(255);
        builder.Property(m => m.VnValue)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.EnValue)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.GroupCode)
            .HasMaxLength(100);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");

              builder
       .HasIndex(u => u.Code)
       .IsUnique();
    }
}