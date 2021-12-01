using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace account.Entity
{
    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id {get; set;}
        [Required]
        public string Firstname {get; set;}       
        public string Middlename {get; set;}
        [Required]
        public string Lastname {get; set;}
        [Required]
        public string Phone {get; set;}
        [Required]
        public string Email {get; set;}
        [Required]
        public string Username {get; set;}
        [Required]
        public DateTimeOffset CreateAt {get; set;}
        [Required]
        public DateTimeOffset ModifiedAt {get; set;}
        [Required]
        public string Password {get; set;}

        [Obsolete("Used only for entity binding!",true)]
        public User() { }
        public User(string firstname, string middlename, string lastname, string phone, string email, string password)
        {
            Id = Guid.NewGuid();
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Phone = phone;
            Email = email;
            Username = Email.Split('@',StringSplitOptions.RemoveEmptyEntries)[0];
            CreateAt = DateTimeOffset.UtcNow;
            ModifiedAt = DateTimeOffset.UtcNow;
            Password = password;
        }
    }
}