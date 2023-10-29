using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointments");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Date)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(e => e.Time)
                .HasColumnType("time")
                .IsRequired();

            builder.HasOne(p => p.Customers)
                .WithMany(p => p.Appointments)
                .HasForeignKey(p => p.IdCustomer);

            builder.HasOne(p => p.Pets)
                .WithMany(p => p.Appointments)
                .HasForeignKey(p => p.IdPet);

            builder.HasOne(p => p.Services)
                .WithMany(p => p.Appointments)
                .HasForeignKey(p => p.IdService);
        }
    }
}