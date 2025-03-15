using WalksAndTrails.API.Models.Domain; 

namespace WalksAndTrails.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsyc();
    }
}
