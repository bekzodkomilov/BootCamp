using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizza.Entity
{
    public class Pizza_Entity
    {
     
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(3)]
        [MinLength(3)]
        public string ShortName { get; set; }

        public EPizzaStockStatus StockStatus { get; set; }

        [MaxLength(1024)]        
        public string Ingredients { get; set; }
        

        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        public DateTimeOffset CreateAt { get; set; }
        public DateTimeOffset ModifiedAt { get; set; }

            public Pizza_Entity( string title ="", string shortName = "", EPizzaStockStatus stockStatus = EPizzaStockStatus.In, string ingredients ="", double price = 0.0)
        {
            Id = Guid.NewGuid();
            Title = title;
            ShortName = shortName;
            StockStatus = stockStatus;
            Ingredients = ingredients;
            Price = price;
            CreateAt = DateTimeOffset.UtcNow;
            ModifiedAt = DateTimeOffset.UtcNow;
        }
    }   
}