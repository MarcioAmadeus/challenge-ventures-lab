using DevIO.Business.Models;
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
        }
    }
}