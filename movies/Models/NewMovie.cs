using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movies.Models
{
    public class NewMovie
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
    
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }

        [Required]
        [Range(0,10)]
        public double Rating { get; set; }
         
         [Required]
        public DateTimeOffset ReleaseDate { get; set; }

        public IEnumerable<Guid> GenreIds { get; set; }
        public IEnumerable<Guid> ActorIds { get; set; }
 
    }
}