﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksAndTrails.API.Models.Domain;
using WalksAndTrails.API.Models.DTO;
using WalksAndTrails.API.Repositories;

namespace WalksAndTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        // POST : api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto request)
        {
            ValidateFileUpload(request);

            if(ModelState.IsValid)
            {
                // convert DTO to Domain Model
                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length,
                    FileName = request.FileName,
                    FileDescription = request.FileDescription,
                };

                // User Repository to upload image
                await imageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);
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
