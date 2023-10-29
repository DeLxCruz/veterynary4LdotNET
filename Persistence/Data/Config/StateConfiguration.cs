using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("States");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.StateName)
                 .IsRequired()
                 .HasMaxLength(50);
            
            builder.HasOne(p => p.Countries)
                .WithMany(p => p.States)
                .HasForeignKey(p => p.IdCountry);
        }
    }
}