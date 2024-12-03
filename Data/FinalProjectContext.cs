using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { ID = 1, FirstName = "Steve", LastName = "North", Birthdate = new DateTime(2004, 08, 11), Program = "Software", Year = "junior" },
                new TeamMember { ID = 2, FirstName = "Jack", LastName = "Cooper", Birthdate = new DateTime(2015, 12, 31), Program = "test", Year = "test" },
                new TeamMember { ID = 3, FirstName = "Isan", LastName = "Kalhan", Birthdate = new DateTime(2015, 12, 31), Program = "test", Year = "test" },
                new TeamMember { ID = 4, FirstName = "Earl", LastName = "Schreck", Birthdate = new DateTime(2015, 12, 31), Program = "test", Year = "test" },
                new TeamMember { ID = 5, FirstName = "Jon", LastName = "Soriano Sanjuan", Birthdate = new DateTime(2000, 05, 11), Program = "Software", Year = "Junior" }
                );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyID = 5, HobbyName = "Playing Piano", HobbyDescription = "Playing classical piano music", HobbyAge = new DateTime(2010, 01, 10), HobbyActive = false, HobbyDifficulty = "Medium" }

                );

            modelBuilder.Entity<FavoriteSong>().HasData(
                new FavoriteSong { FavoriteSongID = 1, TeamMemberID = 1, SongName = "Bohemian Rhapsody", Artist = "Queen" },
                new FavoriteSong { FavoriteSongID = 5, TeamMemberID = 5, SongName = "Wildfire", Artist = "Black Out The Sun" }
                );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { ID = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8 },
                new FavoriteMovie { ID = 5, Title = "Smile 2", Director = "Parker Finn", ReleaseDate = new DateTime(2024, 10, 24), Genre = "Horror", Rating = 8.5 }
                );
        }


        public DbSet<FinalProject.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;
        public DbSet<FavoriteSong> FavoriteSong { get; set; } = default!;
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; } = default!;

    }
}
