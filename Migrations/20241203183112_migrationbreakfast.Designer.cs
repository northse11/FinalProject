﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20241203183112_migrationbreakfast")]
    partial class migrationbreakfast
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Models.BreakfastItems", b =>
                {
                    b.Property<int>("breakfastID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("breakfastID"));

                    b.Property<string>("breakfastItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("breakfastItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("breakfastItemPrice")
                        .HasColumnType("int");

                    b.Property<int>("breakfastItemQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("breakfastTime")
                        .HasColumnType("datetime2");

                    b.HasKey("breakfastID");

                    b.ToTable("BreakfastItems");
                });

            modelBuilder.Entity("FinalProject.Models.FavoriteMovie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FavoriteMovie");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Director = "Christopher Nolan",
                            Genre = "Sci-Fi",
                            Rating = 8.8000000000000007,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            ID = 2,
                            Director = "Irvin Kershner",
                            Genre = "Sci-Fi",
                            Rating = 8.6999999999999993,
                            ReleaseDate = new DateTime(1980, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Star Wars: Episode V - The Empire Strikes Back"
                        },
                        new
                        {
                            ID = 3,
                            Director = "M Night Shyamalan",
                            Genre = "Sci-Fi",
                            Rating = 10.0,
                            ReleaseDate = new DateTime(2002, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Signs"
                        },
                        new
                        {
                            ID = 4,
                            Director = "Parker Finn",
                            Genre = "Horror",
                            Rating = 8.5,
                            ReleaseDate = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Smile 2"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.FavoriteSong", b =>
                {
                    b.Property<int>("FavoriteSongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteSongID"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamMemberID")
                        .HasColumnType("int");

                    b.HasKey("FavoriteSongID");

                    b.HasIndex("TeamMemberID");

                    b.ToTable("FavoriteSong");

                    b.HasData(
                        new
                        {
                            FavoriteSongID = 1,
                            Artist = "Queen",
                            SongName = "Bohemian Rhapsody",
                            TeamMemberID = 4
                        },
                        new
                        {
                            FavoriteSongID = 2,
                            Artist = "Duran Duran",
                            SongName = "Invisible",
                            TeamMemberID = 2
                        },
                        new
                        {
                            FavoriteSongID = 3,
                            Artist = "Eagles",
                            SongName = "Lyin' Eyes",
                            TeamMemberID = 1
                        },
                        new
                        {
                            FavoriteSongID = 4,
                            Artist = "Black Out The Sun",
                            SongName = "Wildfire",
                            TeamMemberID = 5
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyID"));

                    b.Property<bool>("HobbyActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HobbyAge")
                        .HasColumnType("datetime2");

                    b.Property<string>("HobbyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyDifficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyID");

                    b.ToTable("Hobby");

                    b.HasData(
                        new
                        {
                            HobbyID = 1,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Hobby....",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Hobby"
                        },
                        new
                        {
                            HobbyID = 2,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing the trumpet for the University of Cincinnati Marching Band.",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Marching Band"
                        },
                        new
                        {
                            HobbyID = 3,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Learning new recipes and cooking new foods",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Cooking"
                        },
                        new
                        {
                            HobbyID = 4,
                            HobbyActive = false,
                            HobbyAge = new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing classical piano music",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Playing Piano"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.TeamMember", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TeamMember");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthdate = new DateTime(2004, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Steve",
                            LastName = "North",
                            Program = "Software",
                            Year = "junior"
                        },
                        new
                        {
                            ID = 2,
                            Birthdate = new DateTime(2003, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jack",
                            LastName = "Cooper",
                            Program = "IT",
                            Year = "test"
                        },
                        new
                        {
                            ID = 3,
                            Birthdate = new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Isan",
                            LastName = "Kalhan",
                            Program = "test",
                            Year = "test"
                        },
                        new
                        {
                            ID = 4,
                            Birthdate = new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Earl",
                            LastName = "Schreck",
                            Program = "test",
                            Year = "test"
                        },
                        new
                        {
                            ID = 5,
                            Birthdate = new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jon",
                            LastName = "Soriano Sanjuan",
                            Program = "Software",
                            Year = "Junior"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.FavoriteSong", b =>
                {
                    b.HasOne("FinalProject.Models.TeamMember", "TeamMember")
                        .WithMany()
                        .HasForeignKey("TeamMemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });
#pragma warning restore 612, 618
        }
    }
}