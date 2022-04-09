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
    public class BusManufacturerConfiguration : IEntityTypeConfiguration<BusManufacturer>
    {
        public void Configure(EntityTypeBuilder<BusManufacturer> builder)
        {
            builder.HasKey(bu => bu.Id);
            builder.Property(bu => bu.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.HasData(
                new BusManufacturer(1, "Mercedes"),
                new BusManufacturer(2, "Wolksvagen"),
                new BusManufacturer(3, "BMW"),
                new BusManufacturer(4, "TESLA"),
                new BusManufacturer(5, "MAN")
                );
        }
    }
}
