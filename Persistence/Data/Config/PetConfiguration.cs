using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pets");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(20);

            builder.Property(e => e.Specie)
                 .IsRequired()
                 .HasMaxLength(20);

            builder.HasOne(p => p.Breeds)
                .WithMany(p => p.Pets)
                .HasForeignKey(p => p.IdBreed);

            builder.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasColumnType("date");

            builder.HasOne(p => p.Customers)
                .WithMany(p => p.Pets)
                .HasForeignKey(p => p.IdCustomer);
        }
    }
}