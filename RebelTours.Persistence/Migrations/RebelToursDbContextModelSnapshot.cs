﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RebelTours.Persistence;

namespace RebelTours.Persistence.Migrations
{
    [DbContext(typeof(RebelToursDbContext))]
    partial class RebelToursDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RebelTours.Domain.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusModelId")
                        .HasColumnType("int");

                    b.Property<int>("DistanceTraveled")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationPlate")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("SeatMapping")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusModelId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("RebelTours.Domain.BusManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("BusManufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wolksvagen"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TESLA"
                        },
                        new
                        {
                            Id = 5,
                            Name = "MAN"
                        });
                });

            modelBuilder.Entity("RebelTours.Domain.BusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusManufacturerId")
                        .HasColumnType("int");

                    b.Property<bool>("HasToilet")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("SeatCapacity")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusManufacturerId");

                    b.ToTable("BusModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusManufacturerId = 1,
                            HasToilet = true,
                            Name = "Travego",
                            SeatCapacity = 44,
                            Type = 2
                        },
                        new
                        {
                            Id = 2,
                            BusManufacturerId = 2,
                            HasToilet = true,
                            Name = "Neoplan",
                            SeatCapacity = 44,
                            Type = 2
                        },
                        new
                        {
                            Id = 3,
                            BusManufacturerId = 3,
                            HasToilet = false,
                            Name = "Connecto",
                            SeatCapacity = 44,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            BusManufacturerId = 4,
                            HasToilet = true,
                            Name = "Travego",
                            SeatCapacity = 44,
                            Type = 2
                        },
                        new
                        {
                            Id = 5,
                            BusManufacturerId = 5,
                            HasToilet = false,
                            Name = "Travego",
                            SeatCapacity = 44,
                            Type = 2
                        });
                });

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

            modelBuilder.Entity("RebelTours.Domain.Bus", b =>
                {
                    b.HasOne("RebelTours.Domain.BusModel", "BusModel")
                        .WithMany()
                        .HasForeignKey("BusModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusModel");
                });

            modelBuilder.Entity("RebelTours.Domain.BusModel", b =>
                {
                    b.HasOne("RebelTours.Domain.BusManufacturer", "BusManufacturer")
                        .WithMany()
                        .HasForeignKey("BusManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusManufacturer");
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
