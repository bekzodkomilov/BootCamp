
using System;

namespace Bootcamp.Solutions
{
    public class Lab2
    {
          public void Problem1()
        {
           Console.WriteLine(222222);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(222222);
        }
        public void Problem2()
        {
           Console.WriteLine("  A");
           Console.WriteLine(" A A");
           Console.WriteLine("AAAAA");
        }
        public void Problem3()
        {
           Console.WriteLine("Brithdate");

            Console.Write("Enter Month: ");
            string son = Console.ReadLine();

            int a = int.Parse(son);
            // string e = String.Format("{0:D2},a");
            Console.Write("Enter Date: ");
            string b = Console.ReadLine();

            int d = int.Parse(son);
           string e = a.ToString().PadLeft(2,'0');
           string k = b.ToString().PadLeft(2,'0');

            Console.WriteLine("Brithdate is" + " "  +  e  + '-' +  k);
        }
        public void Problem4()
        {
          
         System.Console.WriteLine("Sun"+" "+"Mon"+" "+"Tue"+" "+"Wed"+" "+"Thr"+" "+"Fri"+" "+"Sat");
         System.Console.WriteLine("    "+1+"    "+2+"   "+3+"   "+4+"   "+5+"   "+6);
         
           
        }
        public void Problem5()
        {  int son;
           son = Convert.ToInt32(Console.Read());

           Console.WriteLine(son + "" + son + "" + son + "" + son + "" +son + "" + son);
           Console.WriteLine(son + "    " + son);
           Console.WriteLine(son + "    " + son);
           Console.WriteLine(son + "" + son + "" + son + "" + son + "" +son + "" + son);
           

        }
        public void Problem7()
        {
           string x = System.Console.ReadLine();
           int n = int.Parse(x);
           for (int i=1; i<=9; i++)
           {
               Console.WriteLine(n+"*"+i+"="+n*i);
           }
        }
        public void Problem8()
        {
            int i,fact=1,number;      
            Console.Write("Enter any Number: ");      
            number= int.Parse(Console.ReadLine());     
            for(i=1;i<=number;i++)
            {      
                fact=fact*i;      
            }      
            Console.WriteLine("Factorial of " +number+" is: "+fact);
        }
        
        public void Problem9()
        {
          
          int n1=0,n2=1,n3,i,number;     
          
          number = int.Parse(Console.ReadLine());  
          Console.Write(n1+" "+n2+" "); //printing 0 and 1    
          for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
          {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
          } 
        }    
    }
}