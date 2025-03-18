using Microsoft.AspNetCore.Identity;

namespace WalksAndTrails.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
