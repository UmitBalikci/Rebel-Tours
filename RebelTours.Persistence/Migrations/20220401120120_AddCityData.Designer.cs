// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RebelTours.Persistence;

namespace RebelTours.Persistence.Migrations
{
    [DbContext(typeof(RebelToursDbContext))]
    [Migration("20220401120120_AddCityData")]
    partial class AddCityData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RebelTours.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bartın"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Eskişehir"
                        },
                        new
                        {
                            Id = 5,
                            Name = "İzmir"
                        });
                });

            modelBuilder.Entity("RebelTours.Domain.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Büyük İstanbul Otogari"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Alibeyköy"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Aşti"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Name = "Terminal"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 4,
                            Name = "Terminal"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 5,
                            Name = "Terminal"
                        });
                });

            modelBuilder.Entity("RebelTours.Domain.Station", b =>
                {
                    b.HasOne("RebelTours.Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
