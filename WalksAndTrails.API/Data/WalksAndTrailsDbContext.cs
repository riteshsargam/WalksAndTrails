using Microsoft.EntityFrameworkCore;
using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Data
{
    public class WalksAndTrailsDbContext: DbContext
    {
        public WalksAndTrailsDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
