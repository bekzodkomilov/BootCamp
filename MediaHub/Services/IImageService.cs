using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using mediahub.Entity;
using mediaimage.Entity;

namespace mediahub.Services
{
    public interface IImageService
    {
     Task<(bool IsSuccess, Exception Exception, MediaImage MediaImage)> CreateAsync(MediaImage actor); 
    Task<MediaImage> GetAsync(Guid id);
    Task<List<MediaImage>> GetAllAsync(string fullname);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
    }
}