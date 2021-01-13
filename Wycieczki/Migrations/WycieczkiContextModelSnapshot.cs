﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wycieczki.Model;

namespace Wycieczki.Migrations
{
    [DbContext(typeof(WycieczkiContext))]
    partial class WycieczkiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Wycieczki.Model.WycieczkaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("dataWycieczki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("konieTrasy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liczbaDni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poczatekTrasy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pokonanyDystans")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zdjecie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Wycieczki");
                });
#pragma warning restore 612, 618
        }
    }
}
