using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasOne(p => p.Customers)
                .WithOne(p => p.Users)
                .HasForeignKey<User>(p => p.CustomerId);

            builder.Property(e => e.Username)
                 .IsRequired()
                 .HasMaxLength(20);
            
            builder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);
            
            builder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
        }
    }
}