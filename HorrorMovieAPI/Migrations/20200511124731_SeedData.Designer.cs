﻿// <auto-generated />
using System;
using HorrorMovieAPI.DB_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HorrorMovieAPI.Migrations
{
    [DbContext(typeof(HorrorContext))]
    [Migration("20200511124731_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HorrorMovieAPI.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthCountry = "USA",
                            BirthTown = "Burbank, California",
                            DOB = new DateTime(1957, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tony",
                            LastName = "Moran"
                        },
                        new
                        {
                            Id = 2,
                            BirthCountry = "USA",
                            BirthTown = "Clifton, New Yersey",
                            DOB = new DateTime(1973, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vera",
                            LastName = "Farmiga"
                        });
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Casting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Casting");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            Character = "Michael Myers (age 23)",
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            Character = "Loraine Warren",
                            MovieId = 2
                        });
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthThown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Director");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthCountry = "USA",
                            DOB = new DateTime(1948, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            LastName = "Carpenter"
                        },
                        new
                        {
                            Id = 2,
                            BirthCountry = "Malaysia",
                            DOB = new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "James",
                            LastName = "Wan"
                        });
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Slasher"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paranormal"
                        });
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            GenreId = 1,
                            Length = 91,
                            Title = "Halloween",
                            Year = 1978
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 2,
                            GenreId = 2,
                            Length = 112,
                            Title = "The Conjuring",
                            Year = 2013
                        });
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Casting", b =>
                {
                    b.HasOne("HorrorMovieAPI.Models.Actor", "Actor")
                        .WithMany("Castings")
                        .HasForeignKey("ActorId");

                    b.HasOne("HorrorMovieAPI.Models.Movie", "Movie")
                        .WithMany("Castings")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("HorrorMovieAPI.Models.Movie", b =>
                {
                    b.HasOne("HorrorMovieAPI.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId");

                    b.HasOne("HorrorMovieAPI.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
