using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CustomerPhoneConfiguration : IEntityTypeConfiguration<CustomerPhone>
    {
        public void Configure(EntityTypeBuilder<CustomerPhone> builder)
        {
            builder.ToTable("CustomerPhones");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.PhoneNumber)
                 .IsRequired()
                 .HasMaxLength(20);

            builder.HasOne(p => p.Customers)
                .WithMany(p => p.CustomersPhone)
                .HasForeignKey(p => p.IdCsutomer);
        }
    }
}