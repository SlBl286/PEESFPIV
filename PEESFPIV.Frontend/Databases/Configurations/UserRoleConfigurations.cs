using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class UserRoleConfigurations : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRole");
        builder.HasOne(m=>m.Role).WithMany().HasForeignKey(nameof(UserRole.RoleId));
        builder.HasOne(m=>m.User).WithMany().HasForeignKey(nameof(UserRole.UserId));

        builder.HasKey(m=> new { m.UserId , m.RoleId });

        builder.Property(m=>m.UserId);
        builder.Property(m=>m.RoleId);

    }
}