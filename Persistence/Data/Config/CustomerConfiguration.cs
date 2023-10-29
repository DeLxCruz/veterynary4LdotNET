using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(e => e.Lastname)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(e => e.Email)
                 .IsRequired()
                 .HasMaxLength(80);

        }
    }
}