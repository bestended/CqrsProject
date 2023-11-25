﻿// <auto-generated />
using CqrsProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CqrsProject.Migrations
{
    [DbContext(typeof(PersonalContext))]
    [Migration("20231122173010_crs")]
    partial class crs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CqrsProject.Data.Personals", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PersonelId");

                    b.ToTable("Personals");

                    b.HasData(
                        new
                        {
                            PersonelId = 1,
                            Age = 38,
                            LastName = "Sarı",
                            Name = "Sinan",
                            Salary = 50000m
                        },
                        new
                        {
                            PersonelId = 2,
                            Age = 37,
                            LastName = "Kaya",
                            Name = "Suzan",
                            Salary = 60000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}