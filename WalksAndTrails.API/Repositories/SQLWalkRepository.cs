using Microsoft.EntityFrameworkCore;
using WalksAndTrails.API.Data;
using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly WalksAndTrailsDbContext dbContext;

        public SQLWalkRepository(WalksAndTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await dbContext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }
    }
}
