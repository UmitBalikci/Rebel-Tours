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
                .HasColumnType("smallint");
            builder.Property(bu => bu.SeatMapping)
                .IsRequired();

            builder.Property(bu => bu.DistanceTraveled)
                .HasColumnType("int");

            builder.HasData(
                new Bus(1, 1, "34RTE61",2002, SeatingType.Standard,500),
                new Bus(2, 2, "34BTN25",2001, SeatingType.Standard,500),
                new Bus(3, 3, "34CZN53",1999, SeatingType.Standard,500),
                new Bus(4, 4, "34ASD98",1994, SeatingType.Standard,500),
                new Bus(5, 5, "34NSR54",1998, SeatingType.Standard,500));
        }
    }
}
