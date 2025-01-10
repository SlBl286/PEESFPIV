using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class OutcomeConfigurations : IEntityTypeConfiguration<Outcome>
{
    public void Configure(EntityTypeBuilder<Outcome> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<Outcome> builder)
    {
        builder.ToTable("Outcome");
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