using System;

namespace Bootcamp.Solutions
{
    public class Lab3
    {

         public void Problem1()
        {
            string a = Console.ReadLine();
            int b=int.Parse(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(Convert.ToChar(b));
        }

         public void Problem2()
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area->"+width*length);
        }
        public void Problem3()
        {
        
        float n;
        if (!float.TryParse(Console.ReadLine(), out n))
           {
            Console.WriteLine("Not a valid float");
           }
        else 
            {
             Console.WriteLine(Math.Round(n));
            }  
        }

         public void Problem4()
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            float c=float.Parse(a);
            float d = float.Parse(b);
            Console.WriteLine("Area->"+c*d);
        }
        public void Problem5_6()
        {
            char ch;
            Char.TryParse(Console.ReadLine(), out ch);
            if (ch>=65 && ch<=90)
            {
                Console.WriteLine(char.ToLower(ch));
            }  
            else if (ch>=97 && ch<=122)
            {
                Console.WriteLine(char.ToUpper(ch));
            }        
        }
              
    }
}