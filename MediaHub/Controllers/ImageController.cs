using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using mediahub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mediaimage.Controllers
{
    public class ImageController
    {
            
        [ApiController]
        [Route("api/[controller]")]
        public class ImageController : ControllerBase
        {
        private readonly IImageService _im;

        public ImageController(IImageService imageService)
        {
            _im = imageService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(await _im.GetAllAsync(string.Empty), options);
            return Ok(json);
        }

        [HttpPost]
        [Route("{id}/images")]
        public async Task<IActionResult> PostImagesAsync(Guid id, IEnumerable<IFormFile> files)
        {
            if(!await _im.ExistsAsync(id))
            {
                return NotFound("Movie with given ID does not exist!");
            }

            var extensions = new string[] { ".jpg", ".png", ".svg", ".mp4" };
            var fileSize = 5242880; // 5MB in bytes

            if(files.Count() < 1 || files.Count() > 5)
            {
                return BadRequest("Can upload 1~5 files at a time.");
            }

            // extension validation
            foreach(var file in files)
            {
                var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
                if(!extensions.Contains(fileExtension))
                {
                    return BadRequest($"{fileExtension} format file not allowed!");
                }

                if(file.Length > fileSize)
                {
                    return BadRequest($"Max file size 5MB!");
                }
            }

            return Ok();
        }

        [HttpGet("{movieId}/images/{imageId}")]
        public async Task<IActionResult> GetImageAsync(Guid movieId, Guid imageId)
        {
            if(!await _im.ExistsAsync(movieId) || !await _im.ExistsAsync(imageId))
            {
                return NotFound();
            }

            var image = await _im.GetAsync(imageId);

            return File(new MemoryStream(image.Data), image.ContentType);
        }

        [HttpGet("{movieId}/images")]
        public async Task<IActionResult> GetImageAsync(Guid movieId)
        {
            if(!await _im.ExistsAsync(movieId))
            {
                return NotFound();
            }

            var images = await _im.GetAsync(movieId);

            return Ok(images);
        }

        }
    }
}