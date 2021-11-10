using System.ComponentModel.DataAnnotations;

namespace account.Model
{
    public class NewUser 
    { 
       
        [Required]
        [MaxLength(20)]
        public string Firstname {get; set;}
        [MaxLength(20)]       
        public string Middlename {get; set;}
        [Required]
        [MaxLength(20)]
        public string Lastname {get; set;}
        [Required]
        [Phone]
        public string Phone {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        public string Password {get; set;}

    }
}