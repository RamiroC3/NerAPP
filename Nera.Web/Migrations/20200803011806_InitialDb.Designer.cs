﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nera.Web.Data;

namespace Nera.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200803011806_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nera.Web.Data.Entities.Rescatista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Rescatistas");
                });
#pragma warning restore 612, 618
        }
    }
}
