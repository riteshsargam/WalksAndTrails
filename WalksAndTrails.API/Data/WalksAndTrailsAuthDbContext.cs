using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WalksAndTrails.API.Data
{
    public class WalksAndTrailsAuthDbContext: IdentityDbContext
    {
        public WalksAndTrailsAuthDbContext(DbContextOptions<WalksAndTrailsAuthDbContext> options): base(options)
        {
            
        }
    }
}
