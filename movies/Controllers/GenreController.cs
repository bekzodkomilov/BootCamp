using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using movies.Entity;
using movies.Mappers;
using movies.Models;

namespace movies.Controllers
{

            [ApiController]
        [Route("api/[controller]")]
        public class GenreController : ControllerBase
        {
            private readonly ILogger<GenreController> _logger;
            private readonly IGenreService _genreService;

            public GenreController(ILogger<GenreController> logger, IGenreService genreService)
            {
                
                _genreService = genreService;
            }

            [HttpPost]
            public async Task<IActionResult> PostAsync(NewGenre genre)
            {
                if(await _genreService.ExistsAsync(genre.Name))
                {
                    return Conflict(nameof(genre.Name));
                }

                var result = await _genreService.CreateAsync(genre.ToEntity());
                
                if(result.IsSuccess)
                {
                    return Ok(result.Genre);
                }

                return BadRequest(
                new { 
                    isSuccess = false, 
                    error = result.Exception.Message 
                });
            }

            [HttpGet]
            [Route("{id}")]
            public async Task<IActionResult> GetAsync(Guid id)
            {
                if(await _genreService.ExistsAsync(id))
                {
                    return Ok(await _genreService.GetAsync(id));
                }

                return NotFound();
            }

            [HttpGet]
            public async Task<IActionResult> GetAsync()
                => Ok(await _genreService.GetAllAsync());

            [HttpDelete]
            [Route("{Id}")]
            public async Task<IActionResult> Delete([FromRoute]Guid Id)
               =>Ok(await _genreService.DeleteAsync(Id));
            
        }
}