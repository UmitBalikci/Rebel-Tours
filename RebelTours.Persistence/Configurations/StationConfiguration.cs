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
    class StationConfiguration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(st => st.Id);
            builder.Property(st => st.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.HasOne(st => st.City)
                .WithMany()
                .HasForeignKey(st => st.CityId);

            builder.HasData(
                new Station() { Id = 1, Name = "Büyük İstanbul Otogari", CityId = 1 },
                new Station() { Id = 2, Name = "Alibeyköy", CityId = 1 },
                new Station() { Id = 3, Name = "Aşti", CityId = 2 },
                new Station() { Id = 4, Name = "Terminal", CityId = 3 },
                new Station() { Id = 5, Name = "Terminal", CityId = 4 },
                new Station() { Id = 6, Name = "Terminal", CityId = 5 });
        }
    }
}
