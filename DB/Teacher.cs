using System.ComponentModel.DataAnnotations;
using System;


public partial class Example
{
    public class Teacher 
    {
        [KeyAttribute]
        public int Id {get; set;}

        [StringLength(50, ErrorMessage = "Ismingizni 50 tadan oshira olmaysiz!")]
        public string Firstname {get; set;}
          
        [StringLength(50, ErrorMessage = "Familtangizni 50 tadan oshira olmaysiz!")]     
        public string Lastname {get; set;}
           
        [Required(ErrorMessage ="yoshingiz talab qilinadi!")]
        [Range(25,90, ErrorMessage ="Age must be between 1-120 in years.")]            
        public int Age { get; set; }
        

        [Required(ErrorMessage = "Email talab qilinadi")]
        [DataType(DataType.EmailAddress)]
        [MinLength(6),MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Notog'ri farmatda kiritdingiz!")]      
        public string Email { get; set;}

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Xatolik!!!")]
        public string PhoneNumber { get; set; }


        
    }
}