﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySqlConnect.Data;

namespace MySqlConnect.Migrations
{
    [DbContext(typeof(ReservationContext))]
    [Migration("20200322144615_AddPlacesIdForLocation")]
    partial class AddPlacesIdForLocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MySqlConnect.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<int>("FillStatus");

                    b.Property<string>("Name");

                    b.Property<string>("PlacesId");

                    b.Property<int>("ShopType");

                    b.Property<int>("SlotDuration");

                    b.Property<int>("SlotSize");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MySqlConnect.Entities.LocationOpening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ClosingTime");

                    b.Property<int>("LocationId");

                    b.Property<string>("OpeningDays");

                    b.Property<DateTime>("OpeningTime");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationOpening");
                });

            modelBuilder.Entity("MySqlConnect.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceId");

                    b.Property<string>("HumanReadableToken");

                    b.Property<int>("LocationId");

                    b.Property<string>("ReservationToken");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("MySqlConnect.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MySqlConnect.Entities.Location", b =>
                {
                    b.HasOne("MySqlConnect.Entities.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySqlConnect.Entities.LocationOpening", b =>
                {
                    b.HasOne("MySqlConnect.Entities.Location", "Location")
                        .WithMany("LocationOpenings")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySqlConnect.Entities.Reservation", b =>
                {
                    b.HasOne("MySqlConnect.Entities.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
