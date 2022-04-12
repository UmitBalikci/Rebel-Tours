using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Persistence.Configurations
{
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasKey(bu => bu.Id);
            builder.HasOne(bu => bu.BusModel)
                .WithMany()
                .HasForeignKey(bu => bu.BusModelId);

            builder.Property(bu => bu.RegistrationPlate)
                .HasColumnType("varchar(50)");

            builder.Property(bu => bu.Year)
                .HasColumnType("int");
            builder.Property(bu => bu.SeatMapping)
                .IsRequired();
            builder.Property(bu => bu.SeatCount)
                .HasColumnType("int");
            builder.Property(bu => bu.DistanceTraveled)
                .HasColumnType("int");
        }
    }
}
