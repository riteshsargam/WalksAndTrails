using Microsoft.EntityFrameworkCore;
using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Data
{
    public class WalksAndTrailsDbContext: DbContext
    {
        public WalksAndTrailsDbContext(DbContextOptions<WalksAndTrailsDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty { Id = Guid.Parse("a05b102b-840e-4b4a-a964-9c519678ac66"), Name = "Easy" },
                new Difficulty { Id = Guid.Parse("35e31381-85ad-4e1d-95d8-f37b36fd5017"), Name = "Medium" },
                new Difficulty { Id = Guid.Parse("64a74235-7e9d-4def-9afe-9521be4b3e89"), Name = "Hard" }
            };

            // Seed difficulties to database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Durgam Cheruvu",
                    Code = "DGC",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F239559151%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                },
                new Region                 {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "KBR Park",
                    Code = "KBR",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F171771903%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Botnaical Garden",
                    Code = "BTG",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F246565119%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                },
                new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Indira Park",
                    Code = "INP",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F197890372%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D342x424%26scale%3D2&w=750&q=90"
                },
                new Region                 {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Gandipet Lake Park",
                    Code = "GLP",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F239559151%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                },
                new Region                 {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Golconda Fort",
                    Code = "GCF",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F243755818%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                }
            };

            // Seed regions to database
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
