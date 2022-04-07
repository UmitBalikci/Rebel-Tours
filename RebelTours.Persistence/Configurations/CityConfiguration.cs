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
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.HasData(
                 new City() { Id = 1, Name = "İstanbul" },
                 new City() { Id = 2, Name = "Ankara" },
                 new City() { Id = 3, Name = "Bartın" },
                 new City() { Id = 4, Name = "Eskişehir" },
                 new City() { Id = 5, Name = "İzmir" });
        }
    }
}
