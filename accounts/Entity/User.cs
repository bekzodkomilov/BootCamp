using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace accounts.Entity
{

    public class User
   { 

    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid ID {get; set;}
    [Required]
    public string Firstname {get; set;}
    [Required]
    public string Lastname {get; set;}
      
    public string Middlename {get; set;}
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
    public string password {get; set;}

    [Obsolete("Used only for entity bilding",true)]
    public User() { }
    public User(string firstname, string middlename, string lastname, string phone, string email, string password)
     {
        ID = Guid.NewGuid();
        Firstname = firstname;
        Middlename = middlename;
        Lastname = lastname;
        Phone = phone;
        Email = email;
        Username = Email.Split('@',StringSplitOptions.RemoveEmptyEntries)[0];
        CreateAt = DateTimeOffset.UtcNow;
        ModifiedAt = DateTimeOffset.UtcNow;
        this.password = password;
        }
   }
}