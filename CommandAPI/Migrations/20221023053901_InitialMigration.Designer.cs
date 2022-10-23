﻿// <auto-generated />
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommandAPI.Migrations
{
    [DbContext(typeof(CommandContext))]
    [Migration("20221023053901_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("CommandAPI.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommandLine")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HowTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CommandItems");
                });
#pragma warning restore 612, 618
        }
    }
}
