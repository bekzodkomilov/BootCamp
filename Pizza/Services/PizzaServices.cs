using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using pizza.Data;
using pizza.Entity;
using pizza.Services;

namespace pizza_entity.Service
{
    public class PizzaServices : IPizzaService
    {
        private readonly PizzaDbContext _context;
        private readonly ILogger<PizzaServices> _logger;

        public PizzaServices(PizzaDbContext context, ILogger<PizzaServices> logger)
        {
             _context = context;
             _logger = logger;
        }
        public async Task<(bool IsSuccess, Exception Exception, Pizza_Entity Pizza)> CreatePizzaAsync(Pizza_Entity pizza)
        {
            if(await PizzaExistsAsync(pizza.Id))
            {
                return(false, new ArgumentException($"There is no Pizza with given ID: {pizza.Id}"), null);
                
            }

            try
            {
                await _context.Pizzas.AddAsync(pizza);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Pizza create in DB: {pizza.Id}");

                return(true, null, pizza);
            }
            catch(Exception e)
            {
                _logger.LogInformation($"Create pizza to DB failed: {e.Message}", e);
               
                return(false, e, null);
            }
        }

        public Task<bool> PizzaExistsAsync(Guid id)
        => _context.Pizzas
        .AnyAsync(p => p.Id == id);
       

        public Task<Pizza_Entity> QueryPizzaAsync(Guid id)
       => _context.Pizzas
       .AsNoTracking()
       .Where(p => p.Id == id)
       .FirstOrDefaultAsync();

        public async Task<List<Entity.Pizza_Entity>> QueryPizzasAsync(Guid id = default(Guid),
            string title = default(string),
            string shortname = default(string),
            Entity.EStockStatus? status = null,
            string indergenties = default(string),
            double price = default(double))
     {
          var pizza = _context.Pizzas.AsNoTracking();

           if(id != default(Guid))
            {
                pizza = pizza.Where(t => t.Id == id);
            }

             if(title != default(string))
            {
                pizza = pizza.Where(t => t.Title.ToLower().Equals(title.ToLower()) 
                            || t.Title.ToLower().Contains(title.ToLower()));
            }

             if(shortname != default(string))
            {
                // TO-DO: optimize
                pizza = pizza.Where(t => t.ShortName.ToLower().Equals(shortname.ToLower()));
            }
              if(status.HasValue)
            {
                pizza = pizza.Where(t => t.Status == status.Value);
            }

              if(indergenties != default(string))
            {
                // TO-DO: optimize
                pizza = pizza.Where(t => t.Ingredients.ToLower().Equals(indergenties.ToLower()));
            }

             if(price != default(double))
            {
                pizza = pizza.Where(t => t.Price == price);
            }

            return await pizza.ToListAsync();

       }

        public async Task<(bool IsSuccess, Exception Exception)> RemovePizzaAsync(Guid id)
        {
            if(!await PizzaExistsAsync(id))
            {
                 _logger.LogInformation($"remove pizza to DB failed: {id}");
                return(false, new ArgumentException($"There is no Pizza with given Id: {id}"));
            }
            _context.Pizzas.Remove(await QueryPizzaAsync(id));
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Pizza remove in DB: {id}");
           
            return (true, null);
        }

        public async Task<(bool IsSuccess, Exception Exception, Pizza_Entity Pizza)> UpdatePizzaAsync(Pizza_Entity pizza)
        {
        
             if(!await PizzaExistsAsync(pizza.Id))
          {
            return (false, new ArgumentException($"There is no Pizza with given ID: {pizza.Id}"), null);
          }

            await _context.Pizzas.AnyAsync( t => t.Id == pizza.Id);

            pizza.ModifiedAt = DateTimeOffset.UtcNow;

            _context.Pizzas.Update(pizza);
            await _context.SaveChangesAsync(); 
            _logger.LogInformation($"Pizza update : {pizza.Id}");
            
            return(true, null, pizza);   

       }
    }
}

