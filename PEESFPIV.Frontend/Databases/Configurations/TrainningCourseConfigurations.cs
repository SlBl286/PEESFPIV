using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
namespace PEESFPIV.Frontend.Databases.Configurations;

public class TrainningCourseConfigurations : IEntityTypeConfiguration<TrainingCourse>
{
    public void Configure(EntityTypeBuilder<TrainingCourse> builder)
    {
        ConfigureUserTable(builder);
    }
    private void ConfigureUserTable(EntityTypeBuilder<TrainingCourse> builder)
    {
        builder.ToTable("TrainingCourse");
        builder.HasKey(m => m.Id);
        builder.Property(m => m.VnTitle)
            .HasMaxLength(512);
        builder.Property(m => m.EnTitle)
            .HasMaxLength(512);
        builder.Property(m => m.VnAddress)
            .HasMaxLength(512);
        builder.Property(m => m.EnAddress)
            .HasMaxLength(512);
        builder.Property(m => m.Link)
            .HasMaxLength(512);
                builder.Property(m => m.Link)
            .HasMaxLength(512);
        builder.Property(m => m.Image)
            .HasMaxLength(255);
        builder.Property(m => m.EventDate);
        builder.Property(m => m.NumOfParticipation);
        builder.Property(m => m.UpdatedAt)
          .HasDefaultValueSql("getdate()");
        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("getdate()");

    }
}