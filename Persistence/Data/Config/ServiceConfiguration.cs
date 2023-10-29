using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnType("double");

            builder.Property(e => e.Description)
                 .HasMaxLength(100);
        }
    }
}