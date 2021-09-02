﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Storage;

namespace WebApplication1.Storage.Migrations
{
    [DbContext(typeof(ProductDataContext))]
    partial class ProductDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Storage.Entity.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryForId")
                        .HasColumnName("gCountryForId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("People")
                        .HasColumnName("szPeople")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CountryForId");

                    b.ToTable("tblCity");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnName("szComment")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("tblCountry");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MenuForId")
                        .HasColumnName("gMenuForId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Price")
                        .HasColumnName("szPrice")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("MenuForId");

                    b.ToTable("tblFood");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Size")
                        .HasColumnName("szSize")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<Guid>("VerandaForId")
                        .HasColumnName("gVerandaForId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VerandaForId");

                    b.ToTable("tblMenu");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodForId")
                        .HasColumnName("gFoodForId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Time")
                        .HasColumnName("szTime")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("FoodForId");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityForId")
                        .HasColumnName("gCityForId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Stars")
                        .HasColumnName("szStars")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityForId");

                    b.ToTable("tblRestaurant");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Veranda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("RestaurantForId")
                        .HasColumnName("gRestaurantForId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("YearTime")
                        .IsRequired()
                        .HasColumnName("szYearTime")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RestaurantForId");

                    b.ToTable("tblVeranda");
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.City", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.Country", "CountryFor")
                        .WithMany()
                        .HasForeignKey("CountryForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Food", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.Menu", "MenuFor")
                        .WithMany()
                        .HasForeignKey("MenuForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Menu", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.Veranda", "VerandaFor")
                        .WithMany()
                        .HasForeignKey("VerandaForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Product", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.Food", "FoodFor")
                        .WithMany()
                        .HasForeignKey("FoodForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Restaurant", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.City", "CityFor")
                        .WithMany()
                        .HasForeignKey("CityForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Storage.Entity.Veranda", b =>
                {
                    b.HasOne("WebApplication1.Storage.Entity.Restaurant", "RestaurantFor")
                        .WithMany()
                        .HasForeignKey("RestaurantForId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
