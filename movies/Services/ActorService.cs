using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using movies.Data;
using movies.Entity;

namespace movies.Services{

public class ActorService : IActorService
{
    private readonly MoviesContext _ctx;
        private readonly ILogger<ActorService> _logger;

        public ActorService(MoviesContext context, ILogger<ActorService> logger)
    {
        _ctx = context;
        _logger = logger;
    }

    public async Task<(bool IsSuccess, Exception Exception, Actor Actor)> CreateAsync(Actor actor)
    {
        try
        {
            await _ctx.Actors.AddAsync(actor);
            await _ctx.SaveChangesAsync();

            return (true, null, actor);
        }
        catch(Exception e)
        {
            return (false, e, null);
        }
    }

    public async Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id)
    {
        try
        {
            var actor = await GetAsync(id);

            if(actor == default(Actor))
            {
                return (false, new Exception("Not found"));
            }

            _ctx.Actors.Remove(actor);
            await _ctx.SaveChangesAsync();

            return (true,  null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<bool> ExistsAsync(Guid id)
        => _ctx.Actors.AnyAsync(a => a.Id == id);

    public Task<List<Actor>> GetAllAsync()
        => _ctx.Actors.ToListAsync();

    public Task<List<Actor>> GetAllAsync(string fullname)
        => _ctx.Actors
            .AsNoTracking()
            .Where(a => a.Fullname == fullname)
            .ToListAsync();

    public Task<Actor> GetAsync(Guid id)
        => _ctx.Actors.FirstOrDefaultAsync(a => a.Id == id);

        public async  Task<(bool IsSuccess, Exception Exception, Actor Actor)> UpdateActorAsync(Actor actor)
        {
            if(!await ExistsAsync(actor.Id))
            {
                return(false, new ArgumentException($"There is no Actor with given ID {actor.Id}"),null);

            }
            await _ctx.Actors.AnyAsync( t => t.Id == actor.Id);

            actor.Birthdate = DateTimeOffset.UtcNow;

            _ctx.Actors.Update(actor);

            await _ctx.SaveChangesAsync();
            _logger.LogInformation($"Actor update {actor.Id}");
            
            return(true, null , actor);
        }
    }
}