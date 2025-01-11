using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class PartnersConfigurations : IEntityTypeConfiguration<Partner>
{
    public void Configure(EntityTypeBuilder<Partner> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<Partner> builder)
    {
        builder.ToTable("Partner");
        builder.HasKey(m => m.Id);
              builder.Property(m => m.VnName)
            .HasMaxLength(255);
        builder.Property(m => m.EnName)
            .HasMaxLength(255);
        builder.Property(m => m.Image)
            .HasMaxLength(255);
        builder.Property(m => m.Order);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");

    }
}