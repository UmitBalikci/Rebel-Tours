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
    public class BusModelConfiguration : IEntityTypeConfiguration<BusModel>
    {
        public void Configure(EntityTypeBuilder<BusModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.HasOne(b => b.BusManufacturer)
                .WithMany()
                .HasForeignKey(b => b.BusManufacturerId);
            builder.Property(b => b.Type)
                .IsRequired();
                

            builder.Property(b => b.SeatCapacity)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(b => b.HasToilet)
                .IsRequired();

            builder.HasData(
                new BusModel(1, "Travego", 1, BusType.Coach, 44, true),
                new BusModel(2, "Neoplan", 2, BusType.Coach, 44, true),
                new BusModel(3, "Connecto", 3, BusType.Coach, 44, false),
                new BusModel(4, "Travego", 4, BusType.Coach, 44, true),
                new BusModel(5, "Travego", 5, BusType.Coach, 44, false));
        }
    }
}
