using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace movies.Entity
{
    public interface IGenreService
    {
        Task<(bool IsSuccess, Exception Exception, Genre Genre)> CreateAsync(Genre genre);
        Task<List<Genre>> GetAllAsync();
        Task<Genre> GetAsync(Guid id);
        Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> ExistsAsync(string name);

    }
}