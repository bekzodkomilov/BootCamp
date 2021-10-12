using System;

namespace Bootcamp.Solutions
{
    public class Lab4
    {

        public void Problem1()
        {
            string n = Console.ReadLine();
            int x = int.Parse(n);
            Console.WriteLine(x / 10000 + "!" + x / 1000 % 10 + "!" + 
                              x / 100 % 10 + "!" + x / 10 % 10 + "!" + x % 10);
        }
           public void Problem2()
        {
            string x = Console.ReadLine();
            int n = int.Parse(x);
            Console.WriteLine((n / 3600).ToString().PadLeft(2, '0') + ":" + 
            (n % 3600 / 60).ToString().PadLeft(2, '0')  + ":" + (n % 60).ToString().PadLeft(2, '0'));
        }
         public void Problem3()
        {
            string x = Console.ReadLine();
            int n = int.Parse(x);
            Console.WriteLine(n / 100 % 10);
        }
         public void Problem4()
        {
            string x = Console.ReadLine();
            int n = int.Parse(x);
            Console.WriteLine((n / 100 % 10 < 5 ? (n / 1000) * 1000 : (n / 1000 + 1) * 1000));
        }

         public void Problem5()
        {
            string x = Console.ReadLine();
            double num = double.Parse(x);
            double PI = 3.14;
            double r = num / (2 * PI);
            double area = PI * r * r;

            int i = (int)Math.Round(area, MidpointRounding.AwayFromZero);

            Console.WriteLine(i);
        }

         public void Problem6()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if(num >= 20 && num <= 30)
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }

         public void Problem7()
        {
            string n = Console.ReadLine();
            char x = char.Parse(n);
            if((x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z'))
            {
                System.Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

          public void Problem8()
        {
            string x = Console.ReadLine();
            int num = int.Parse(x);
            if(num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

         public void Problem9()
        {
            string n = Console.ReadLine();
            string x = Console.ReadLine();
            int n1 = int.Parse(n);
            int x1 = int.Parse(x);
            Console.WriteLine((n1 > x1 ? n1 : x1));
        }
       
         public void Problem10()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            Console.WriteLine((num1 > num2 ? num1 / num2 : num2 / num1));
            Console.WriteLine((num1 > num2 ? num1 % num2 : num2 % num1));

        }   

    }
} 