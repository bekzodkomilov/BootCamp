using System;
using System.ComponentModel.DataAnnotations;
namespace movies.Models
{
    public class NewActor
    {
        [Required]
        [MaxLength(20)]
        public string Fullname {get; set; }

        [Required]
        public DateTimeOffset Birthdate { get; set; }

    }
}