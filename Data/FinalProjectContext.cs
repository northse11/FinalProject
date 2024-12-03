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
                new TeamMember { ID = 2, FirstName = "Jack", LastName = "Cooper", Birthdate = new DateTime(2003, 06, 17), Program = "IT", Year = "test" },
                new TeamMember { ID = 3, FirstName = "Isan", LastName = "Kalhan", Birthdate = new DateTime(2015, 12, 31), Program = "test", Year = "test" },
                new TeamMember { ID = 4, FirstName = "Earl", LastName = "Schreck", Birthdate = new DateTime(2003, 08, 14), Program = "test", Year = "test" },
                new TeamMember { ID = 5, FirstName = "Jon", LastName = "Soriano Sanjuan", Birthdate = new DateTime(2000, 05, 11), Program = "Software", Year = "Junior" }
                );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyID = 1, HobbyName = "Hobby", HobbyDescription = "Hobby....", HobbyAge = new DateTime(2015, 12, 31), HobbyActive = true, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 2, HobbyName = "Marching Band", HobbyDescription = "Playing the trumpet for the University of Cincinnati Marching Band.", HobbyAge = new DateTime(2022, 8, 01), HobbyActive = true, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 3, HobbyName = "Cooking", HobbyDescription = "Learning new recipes and cooking new foods", HobbyAge = new DateTime(2020, 10, 10), HobbyActive = true, HobbyDifficulty = "Medium" },
                new Hobby { HobbyID = 4, HobbyName = "Playing Piano", HobbyDescription = "Playing classical piano music", HobbyAge = new DateTime(2010, 01, 10), HobbyActive = false, HobbyDifficulty = "Medium" }

                );

            modelBuilder.Entity<FavoriteSong>().HasData(
                new FavoriteSong { FavoriteSongID = 1, TeamMemberID = 4, SongName = "Bohemian Rhapsody", Artist = "Queen" },
                new FavoriteSong { FavoriteSongID = 2, TeamMemberID = 2, SongName = "Invisible", Artist = "Duran Duran" },
                new FavoriteSong { FavoriteSongID = 3, TeamMemberID = 1, SongName = "Lyin' Eyes", Artist = "Eagles" },
                new FavoriteSong { FavoriteSongID = 4, TeamMemberID = 5, SongName = "Wildfire", Artist = "Black Out The Sun" }
                );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { ID = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8 },
                new FavoriteMovie { ID = 2, Title = "Star Wars: Episode V - The Empire Strikes Back", Director = "Irvin Kershner", ReleaseDate = new DateTime(1980, 5, 06), Genre = "Sci-Fi", Rating = 8.7 },
                new FavoriteMovie { ID = 3, Title = "Signs", Director = "M Night Shyamalan", ReleaseDate = new DateTime(2002, 08, 02), Genre = "Sci-Fi", Rating = 10 },
                new FavoriteMovie { ID = 4, Title = "Smile 2", Director = "Parker Finn", ReleaseDate = new DateTime(2024, 10, 24), Genre = "Horror", Rating = 8.5 }
                );
        }


        public DbSet<FinalProject.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;
        public DbSet<FavoriteSong> FavoriteSong { get; set; } = default!;
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; } = default!;

    }
}
