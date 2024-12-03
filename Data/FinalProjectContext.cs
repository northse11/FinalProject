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
                new TeamMember { ID = 1, FirstName = "Steve", LastName = "North", Birthdate = new DateTime(2015, 12, 31), Program = "software", Year = "junior" }
                );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyID = 1, HobbyName = "Hobby", HobbyDescription = "Hobby....", HobbyAge = new DateTime(2015, 12, 31), HobbyActive = true, HobbyDifficulty = "Medium" }
                );

            modelBuilder.Entity<FavoriteSong>().HasData(
                new FavoriteSong { FavoriteSongID = 1, TeamMemberID = 1, SongName = "Bohemian Rhapsody", Artist = "Queen" }
                );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { ID = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8 }
                );
        }


        public DbSet<FinalProject.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;
        public DbSet<FavoriteSong> FavoriteSong { get; set; } = default!;
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; } = default!;

    }
}
