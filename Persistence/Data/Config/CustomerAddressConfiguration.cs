using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("CustomerAddress");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasOne(p => p.Customers)
                .WithOne(p => p.CustomersAddress)
                .HasForeignKey<CustomerAddress>(p => p.IdCustomer);

            builder.HasOne(p => p.Cities)
                .WithOne(p => p.CustomersAddress)
                .HasForeignKey<CustomerAddress>(p => p.IdCity);

            builder.Property(e => e.RoadType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PrimaryNum)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(e => e.Letter)
                 .IsRequired()
                 .HasMaxLength(1);

            builder.Property(e => e.Bis)
                 .IsRequired()
                 .HasMaxLength(3);

            builder.Property(e => e.LetterSec)
                 .IsRequired()
                 .HasMaxLength(2);

            builder.Property(e => e.Cardinal)
                 .IsRequired()
                 .HasMaxLength(10);

            builder.Property(e => e.SecondaryNum)
                .HasColumnType("int");

            builder.Property(e => e.LetterThird);

            builder.Property(e => e.ThirdNum)
                .HasColumnType("int");

            builder.Property(e => e.CardinalSec)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.Complement)
                .HasMaxLength(50);

            builder.Property(e => e.ZipCode)
                 .IsRequired()
                 .HasMaxLength(10);
        }
    }
}