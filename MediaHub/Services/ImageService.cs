

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using mediahub.Data;
using mediahub.Entity;
using mediahub.Services;
using Microsoft.EntityFrameworkCore;

namespace movies.Services
{
    public class ImageService : IImageService
    {
        private readonly MediaContext _ctx;

        public ImageService(MediaContext context)
        {
            _ctx = context;
        }

        public async Task<(bool IsSuccess, Exception Exception, MediaImage MediaImage)> CreateAsync(MediaImage mediaImage)
        {
            try
            {
                await _ctx.Medias.AddAsync(mediaImage);
                await _ctx.SaveChangesAsync();

                return (true, null, mediaImage);
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
                var movie = await GetAsync(id);

                if(movie == default(MediaImage))
                {
                    return (false, new Exception("Not found"));
                }

                _ctx.Medias.Remove(movie);
                await _ctx.SaveChangesAsync();

                return (true,  null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }

    public Task<bool> ExistsAsync(Guid id)
        => _ctx.Medias.AnyAsync(a => a.Id == id);

    public Task<List<MediaImage>> GetAllAsync(string AltText)
        => _ctx.Medias
            .AsNoTracking()
            .Where(a => a.AltText == AltText)
            .ToListAsync();


        public Task<MediaImage> GetAsync(Guid id)
        => _ctx.Medias.FirstOrDefaultAsync(a => a.Id == id);


    }
}
