using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksAndTrails.API.Models.DTO;

namespace WalksAndTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        // POST : api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto request)
        {
            ValidateFileUpload(request);

            if(ModelState.IsValid)
            {
                // User Repository to upload image
            }

            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageUploadRequestDto request)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };

            if (allowedExtensions.Contains(Path.GetExtension(request.FileName)))
            {
                ModelState.AddModelError("File", "Unsupported file extension");
            }

            if (request.File.Length > 10485760)
            {
                ModelState.AddModelError("File", "File size exceeds 10MB");
            }
        }

    }
}
