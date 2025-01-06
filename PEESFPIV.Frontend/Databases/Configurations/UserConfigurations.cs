using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Name)
            .HasMaxLength(255);
        builder.Property(m => m.Avatar)
            .HasMaxLength(100);
        builder.Property(m => m.Username)
            .HasMaxLength(100);
        builder.Property(m => m.Salt)
            .HasMaxLength(255);
        builder.Property(m => m.HashedPassword)
            .HasMaxLength(255);
        builder.Property(m => m.UpdatedAt)
            .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");
        builder
       .HasIndex(u => u.Username)
       .IsUnique();
    }
}