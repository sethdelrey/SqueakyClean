﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqueakyClean.Data;

namespace SqueakyClean.Migrations.Supplies
{
    [DbContext(typeof(SuppliesContext))]
    [Migration("20201214020047_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SqueakyClean.Entities.SupplyItem", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("OutOf")
                        .HasColumnType("bit");

                    b.HasKey("Name");

                    b.ToTable("Supplies");

                    b.HasData(
                        new
                        {
                            Name = "Trash Bags",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Mopping Solution",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Hand Towels",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Paper Towles",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Duster Replacements",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Window Cleaner",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Pumice Stone",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Toilet Bowl Cleaner",
                            OutOf = false
                        },
                        new
                        {
                            Name = "All Purpose Cleaner",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Mop",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Dust Mop",
                            OutOf = false
                        },
                        new
                        {
                            Name = "Vacuum",
                            OutOf = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}