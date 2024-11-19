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
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //How do I add Hobbies to my Database. 
        //    //When do I use add-migration

        //    //base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Entity<Hobby>().HasData(
        //    //    new Hobby { HobbyID = 1, HobbyName = "Coding", HobbyDescription = "Watching Coding YT videos", HobbyAge = new DateTime(2024, 1, 13), HobbyActive = true, HobbyDifficulty = "Hard" }
               
        //    //    );
        //    //modelBuilder.Entity<TeamMember>().HasData(
        //    //    new TeamMember { ID = 1, FirstName = "Jon", LastName = "Sanjuan", Birthdate = new DateTime(2000, 5, 11), Program = "Software Application Development", Year = "Junior" }
        //    //    );
        //}

        public DbSet<FinalProject.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;
    }
}
