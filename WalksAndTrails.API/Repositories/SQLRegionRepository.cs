using Microsoft.EntityFrameworkCore;
using WalksAndTrails.API.Data;
using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly WalksAndTrailsDbContext dbContext;

        public SQLRegionRepository(WalksAndTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Region>> GetAllAsyc()
        {
            return await dbContext.Regions.ToListAsync();
        }
    }
}
