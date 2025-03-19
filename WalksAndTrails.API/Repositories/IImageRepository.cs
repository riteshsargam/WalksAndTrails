using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
