﻿// <auto-generated />
using Explicitloading.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Explicitloading.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20230706071039_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Explicitloading.Data.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Markalar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Peugeot"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Mercedes"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Audi"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Hyundai"
                        });
                });

            modelBuilder.Entity("Explicitloading.Data.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.ToTable("Modeller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "206",
                            MarkaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Ad = "307",
                            MarkaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Ad = "407",
                            MarkaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Ad = "AMG One",
                            MarkaId = 2
                        },
                        new
                        {
                            Id = 5,
                            Ad = "CLS",
                            MarkaId = 2
                        },
                        new
                        {
                            Id = 6,
                            Ad = "EQC",
                            MarkaId = 2
                        },
                        new
                        {
                            Id = 7,
                            Ad = "A1",
                            MarkaId = 3
                        },
                        new
                        {
                            Id = 8,
                            Ad = "A3",
                            MarkaId = 3
                        },
                        new
                        {
                            Id = 9,
                            Ad = "A4",
                            MarkaId = 3
                        },
                        new
                        {
                            Id = 10,
                            Ad = "TT",
                            MarkaId = 3
                        },
                        new
                        {
                            Id = 11,
                            Ad = "Accent Era",
                            MarkaId = 4
                        },
                        new
                        {
                            Id = 12,
                            Ad = "i10",
                            MarkaId = 4
                        },
                        new
                        {
                            Id = 13,
                            Ad = "i20",
                            MarkaId = 4
                        },
                        new
                        {
                            Id = 14,
                            Ad = "i30",
                            MarkaId = 4
                        });
                });

            modelBuilder.Entity("Explicitloading.Data.Model", b =>
                {
                    b.HasOne("Explicitloading.Data.Marka", "Marka")
                        .WithMany("Modeller")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("Explicitloading.Data.Marka", b =>
                {
                    b.Navigation("Modeller");
                });
#pragma warning restore 612, 618
        }
    }
}
