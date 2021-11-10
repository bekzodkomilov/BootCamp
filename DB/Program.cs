using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Collections.Generic;


public partial class Example
{
    public static void Main()
    {       
      Student h1 = new Student() {Id=231,Firstname="sardor",Lastname="siroj",Age=15,Email="sardor@gmail.com",PhoneNumber="998946271166"};

      System.Console.WriteLine(h1.Age+"-"+h1.Email+"-"+h1.Id);
    }
}