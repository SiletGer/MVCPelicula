﻿// <auto-generated />
using System;
using MVCPelicula.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCPelicula.Migrations
{
    [DbContext(typeof(PeliculasDBContext))]
    partial class PeliculasDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCPelicula.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Comedia"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Romance"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Aventura"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Acción"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Ficción"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Drama"
                        });
                });

            modelBuilder.Entity("MVCPelicula.Models.Pelicula", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Director = "Hermanas Wachowski",
                            FechaLanzamiento = new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 4,
                            Precio = 10.99m,
                            Sala = "Sala 1",
                            Titulo = "Matrix recargado"
                        },
                        new
                        {
                            ID = 2,
                            Director = "Peter Jackson",
                            FechaLanzamiento = new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 3,
                            Precio = 11.99m,
                            Sala = "Sala 2",
                            Titulo = "El señor de los anillos: las dos torres"
                        },
                        new
                        {
                            ID = 3,
                            Director = "Chris Columbus",
                            FechaLanzamiento = new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 5,
                            Precio = 9.99m,
                            Sala = "Sala 3",
                            Titulo = "Harry Potter y la camara secreta"
                        });
                });

            modelBuilder.Entity("MVCPelicula.Models.Pelicula", b =>
                {
                    b.HasOne("MVCPelicula.Models.Genero", null)
                        .WithMany("Peliculas")
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("MVCPelicula.Models.Genero", b =>
                {
                    b.Navigation("Peliculas");
                });
#pragma warning restore 612, 618
        }
    }
}
