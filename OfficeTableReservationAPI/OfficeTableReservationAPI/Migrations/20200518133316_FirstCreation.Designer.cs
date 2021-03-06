﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OfficeTableReservationAPI.Models;

namespace OfficeTableReservationAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200518133316_FirstCreation")]
    partial class FirstCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OfficeTableReservationAPI.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("OfficeTableReservationAPI.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum_Reservierung")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("OfficeTableReservationAPI.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Tischnummer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("OfficeTableReservationAPI.Models.Reservation", b =>
                {
                    b.HasOne("OfficeTableReservationAPI.Models.Table", "Table")
                        .WithMany("ReservationList")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OfficeTableReservationAPI.Models.Table", b =>
                {
                    b.HasOne("OfficeTableReservationAPI.Models.Office", "Office")
                        .WithMany("TableList")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
