using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace accounts.Model
{

    public class NewUser 
    {
        [MaxLength(20)]
        [Required]
        public string Firstname {get; set;}
        
        [MaxLength(20)]
        public string Lastname {get; set;}
        [MaxLength(20)]
        public string Middlename {get; set;}
        [Phone]
        public string Phone {get; set;}
        
        [EmailAddress]
        public string Email {get; set;}
        
        public string password {get; set;}
}}