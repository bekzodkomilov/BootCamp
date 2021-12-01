using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pizza.Entity;

namespace pizza.Services
{
    public interface IPizzaService
    {
        Task<List<Entity.Pizza_Entity>> QueryPizzasAsync(Guid id = default(Guid),
            string title = default(string),
            string shortname = default(string),
            Entity.EPizzaStockStatus? status = null,
            string indergenties = default(string),
            double price = default(double));
        Task<Pizza_Entity> QueryPizzaAsync(Guid id);
        Task<(bool IsSuccess, Exception Exception, Pizza_Entity Pizza)> CreatePizzaAsync(Pizza_Entity pizza);
        Task<bool> PizzaExistsAsync(Guid id);
        Task<(bool IsSuccess, Exception Exception, Pizza_Entity Pizza)> UpdatePizzaAsync(Pizza_Entity pizza);
        Task<(bool IsSuccess, Exception Exception)> RemovePizzaAsync(Guid id);
    }
}