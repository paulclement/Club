using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace PClement.Club.Models
{
    public class ClubDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<StadiumField> StadiumFields { get; set; }
        public DbSet<AgeCategory> AgeCategories { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameEvents.Card> Cards { get; set; }
        public DbSet<GameEvents.Goal> Goals { get; set; }
        public DbSet<GameEvents.Substitution> Substitutions { get; set; }

        public DbSet<Competition.Competition> Competitions { get; set; }
        public DbSet<Competition.CompetitionStep> CompetitionsSteps { get; set; }
        public DbSet<Competition.CompetitionEvent> CompetitionsEvents { get; set; }

        public CompetitionSeason CompetitionsSeasons { get; set; }

        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .Property(x => x.Id).IsRequired();
        }
    }
}
