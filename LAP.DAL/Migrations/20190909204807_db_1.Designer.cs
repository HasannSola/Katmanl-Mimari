﻿// <auto-generated />
using System;
using LAP.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LAP.DAL.Migrations
{
    [DbContext(typeof(LapContext))]
    [Migration("20190909204807_db_1")]
    partial class db_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LAP.ENTITIES.Customer", b =>
                {
                    b.Property<int>("InCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("DtCreateTime");

                    b.Property<DateTimeOffset?>("DtUpdateTime");

                    b.Property<float>("FlBalance");

                    b.Property<int>("InStatus");

                    b.Property<string>("StDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("StName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("InCustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LAP.ENTITIES.Order", b =>
                {
                    b.Property<int>("InOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("DtCreateTime");

                    b.Property<DateTimeOffset?>("DtUpdateTime");

                    b.Property<float>("FlQuantity");

                    b.Property<int>("InCustomerId");

                    b.Property<int>("InStatus");

                    b.Property<string>("StDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("StProductName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("InOrderId");

                    b.HasIndex("InCustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("LAP.ENTITIES.Order", b =>
                {
                    b.HasOne("LAP.ENTITIES.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("InCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
