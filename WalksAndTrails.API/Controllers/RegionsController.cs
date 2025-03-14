using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksAndTrails.API.Models.Domain;

namespace WalksAndTrails.API.Controllers
{
    // https://localhost:5001/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // GET All Regions
        // GET : https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Golconda Fort",
                    Code = "GLF",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F290018000%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Durgam Cheruvu",
                    Code = "DGC",
                    RegionImageUrl = "https://www.alltrails.com/_next/image?url=https%3A%2F%2Fwww.alltrails.com%2Fapi%2Falltrails%2Fv3%2Fmaps%2F239559151%2Fstatic_map%3Fkey%3D3p0t5s6b5g4g0e8k3c1j3w7y5c3m4t8i%26size%3D368x205%26scale%3D2&w=750&q=90"
                }
            };

            return Ok(regions);
        }
    }
}
