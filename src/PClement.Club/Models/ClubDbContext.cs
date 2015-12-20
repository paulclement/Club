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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .Property(x => x.Id).IsRequired();
        }
    }
}
