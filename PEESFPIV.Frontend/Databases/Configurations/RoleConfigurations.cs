using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class RoleConfigurations : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Role");
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Name)
            .HasMaxLength(255);
        builder.Property(m => m.Description)
            .HasMaxLength(int.MaxValue - 2);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");
    }
}