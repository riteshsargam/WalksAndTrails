using WalksAndTrails.API.Models.Domain; 

namespace WalksAndTrails.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsyc();

        Task<Region?> GetByIdAsync(Guid id);

        Task<Region> CreateAsync(Region region);

        Task<Region?> UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}
