using System.Linq;
using System;
using System.Threading.Tasks;
using actor.Models;
using Microsoft.AspNetCore.Mvc;
using movies.Mappers;
using movies.Models;
using movies.Services;

namespace movies.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _as;

        public ActorController(IActorService actorService)
        {
            _as = actorService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(NewActor actor)
        {
            var result = await _as.CreateAsync(actor.ToEntity());

            if(result.IsSuccess)
            {
                return Ok();
            }

            return BadRequest(result.Exception.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
            => Ok(await _as.GetAllAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            if(await _as.ExistsAsync(id))
            {
                return Ok(await _as.GetAsync(id));
            }

            return NotFound();
        }

        // [HttpPut]
        // [Route("{id}")]
        // public async Task<IActionResult> UpdateAsync([FromRoute]Guid id,[FromBody]UpdatedActor actor)
        // {
        //    var toActorEntity = actor.
        // }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete([FromRoute]Guid Id)
           =>Ok(await _as.DeleteAsync(Id));
    }
}