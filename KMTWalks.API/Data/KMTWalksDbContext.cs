using KMTWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KMTWalks.API.Data
{
    public class KMTWalksDbContext : DbContext
    {
        public KMTWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

    }
}
