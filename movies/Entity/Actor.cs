using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace movies.Entity
{
    public class Actor
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id{ get; set; } = Guid.NewGuid();

       [Required]
       [MaxLength(255)]
        public string Fullname { get; set; }
        [Required]
        public DateTimeOffset Birthday { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ICollection<Movie> Movies {get; set;}
        public DateTimeOffset Birthdate { get; internal set; }
    }
}