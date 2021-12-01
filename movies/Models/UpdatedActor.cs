using System;
using System.ComponentModel.DataAnnotations;

namespace actor.Models
{
    public class UpdatedActor
    {
         [Required]
        [MaxLength(20)]
        public string Fullname {get; set; }

        [Required]
        public DateTimeOffset Birthdate { get; set; }

    }
}