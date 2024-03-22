using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class TaskManagementMapping : IEntityTypeConfiguration<Business.Models.TaskManagement>
    {
        public void Configure(EntityTypeBuilder<Business.Models.TaskManagement> builder)
        {
            builder.ToTable("TaskManagement");

            builder.HasKey(p => p.Id);

            builder.Property(c => c.UserId)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Date)
                .HasColumnType("varchar(250)");

            builder.Property(c => c.StartTime)
               .HasColumnType("varchar(250)");

            builder.Property(c => c.EndTime)
               .HasColumnType("varchar(250)");

            builder.Property(c => c.Subject)
              .HasColumnType("varchar(250)");

            builder.Property(c => c.Description)
              .HasColumnType("varchar(250)");
        }
    }
}