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
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { ID = 1, FirstName = "Steve", LastName = "North", Birthdate = new DateTime(2015, 12, 31), Program = "software", Year = "junior" });

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyID = 1, HobbyName = "Hobby", HobbyDescription = "Hobby....", HobbyAge = new DateTime(2015, 12, 31), HobbyActive = true, HobbyDifficulty = "Medium"}
                );
        }


        public DbSet<FinalProject.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;
    }
}
