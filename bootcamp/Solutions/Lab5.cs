using System;
using System.Linq;

namespace Bootcamp.Solutions
{
    public class Lab5
    { 

        public void Problem5_1()
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if (a <= -1)
            {
                Console.WriteLine("ichkarida o'yna");
            }
            else if (a == 0 || a <40)      
            {
                Console.WriteLine("tashqarida o'yna");
            }
            else if(a >= 40)
            {
                Console.WriteLine("ichkarida o'yna");
            }
            Console.Read();
            
        }
          public void Problem5_2()
        {
           int N, M;
            N=Convert.ToInt32(Console.ReadLine());
            M=Convert.ToInt32(Console.ReadLine());
            if (N * N == M) Console.WriteLine(N + "*" + N + "=" + M);
            else if (M * M == N) Console.WriteLine(M + "*" + M + "=" + N);
            else Console.WriteLine("none");
            Console.Read();
        }

         public void Problem5_3()
        {
           int a, b, max=0;
            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                max = a;           
            }
            else
            {
                max = b;
            }
            Console.WriteLine($"{max}");
        }

         public void Problem5_4()
        {
            int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if(n1 > n2 && n2 > n3)
            {
                Console.WriteLine($"{n1} {n3}");
            }
            else if(n1 < n2 && n2 < n3)
            {
                Console.WriteLine($"{n3} {n1}");
            }
            else if(n1 < n2 && n2 > n3)
            {
                Console.WriteLine($"{n2} {n3}");
            }
            else if(n1 > n2 && n2 < n3)
            {
                Console.WriteLine($"{n3} {n2}");
                
            }
        }
        public void Problem5_5()
        {
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0 && num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("A");
            }
            else if(num % 2 == 0 && num % 3 == 0)
            {
                System.Console.WriteLine("B");
            }
            else if(num % 2 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("C");
            }
            else if(num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("D");
            }
            else if(num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
            {
                System.Console.WriteLine("E");
            }
            else
            {
                System.Console.WriteLine("N");
            }
        }
         public void Problem5_6()
          {
             int year;
             year=Convert.ToInt32(Console.ReadLine());   
         
             if ((year % 4 == 0 && year % 400 == 0) || (year % 4 == 0 && !(year% 100 == 0)))
             {
                 Console.WriteLine( "leap year");
             }
             else
                 Console.WriteLine(" normal year");

             Console.Read();
          }
        
        public void Problem5_7()
        {
           float a, b;

           a = 5;
           b = Convert.ToInt32(Console.ReadLine());

           if (a == b)
           {
            Console.WriteLine("CORRECT");
           }
            else if (b < a)
            {
              Console.WriteLine("UP");
            }
             else if (b > a)
            { 
              Console.WriteLine("DOWN");
           }
        }
        public void Problem5_8()
        {
            char ch = char.Parse(Console.ReadLine());
            if(ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine((char)(ch - 32));
            }
            else if(ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine((char)(ch + 32));
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }

        public void Problem5_9()
        {

            int strike = 0, ball = 0;

            int[] a = Console.ReadLine().
            Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(item => int.Parse(item))
           .ToArray();
            int[] b = Console.ReadLine().
            Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(item => int.Parse(item)).ToArray();

            if (a[0] == b[0] &&(a[0]!=b[1] && a[0]!=b[2]))strike++;
            if (a[1] == b[1] && (a[1] != b[0] && a[1] != b[2])) strike++;
            if (a[2] == b[2] && (a[2] != b[1] && a[2] != b[0])) strike++;
            if ((b[0]==a[1] || b[0] == a[2])&& a[0]!=b[0]) ball++;
            if ((b[1] == a[0] || b[1] == a[2]) && a[1] != b[1]) ball++;
            if ((b[2] == a[1] || b[2] == a[0]) && a[2] != b[2]) ball++;

            Console.WriteLine(strike + "S" + ball + "B");
             
            Console.Read();
           
        }
        public void Problem5_10()
        {
            int a, b, result = 0;
            char q;
            Console.WriteLine("Enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter character");
            q = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt32(Console.ReadLine());
            if (q == '+')
            {
                result = a + b; 
                Console.WriteLine("{0}", result);
            }else if(q=='-'){
                result = a - b;
                Console.WriteLine("{0}", result);
            }
        }
         public void Problem5_11()
        {
            
            int d, p;

            d = Convert.ToInt32(Console.ReadLine());
            p = Convert.ToInt32(Console.ReadLine());


            switch (d)
             {
              case 1:
                     {
                      Console.WriteLine("Americano");
                      int change = p - 500;
                      Console.WriteLine(change / 500 + " " + change % 500 / 100);
                      break;
                     }
              case 2:
                     {
                      
                      Console.WriteLine("Coffe Late");
                      int change = p - 400;
                      Console.WriteLine(change / 500 + " " + change % 500 / 100);
                      break;
                     }
              case 3:
                     {
                      Console.WriteLine("Lemon Tea");
                      int change = p - 300;
                      Console.WriteLine(change / 500 + " " + change % 500 / 100);
                      break;
                     }
                       default: break;
             }
        }

        public void Problem5_12()
        {
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1: Problem5_4(); break;
                case 2: Problem5_9(); break;
                case 3: Problem5_10(); break;
                default: break;
            }
        }


         public void Problem5_13()
        {
           int d, p;
           int sum,s=100;
           d = Convert.ToInt32(Console.Read());
           p = Convert.ToInt32(Console.Read());

           sum = d + p;

           if (sum >= s)
           {
            Console.WriteLine(true);
           }
           else
           {
            Console.WriteLine(false);
           }
        }
        public void Problem5_14()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if((a * a) + (b * b) == (c * c))
            {
                System.Console.WriteLine(true);
            }
            else if((a * a) + (c * c) == (b * b))
            {
                System.Console.WriteLine(true);
            }
            else if((b * b) + (c * c) == (a * a))
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }

         public void Problem5_15()
        {
            char ch = char.Parse(Console.ReadLine());
            switch(ch)
            {
                case '+': System.Console.WriteLine(true); break;
                case '-': System.Console.WriteLine(true); break;
                case '*': System.Console.WriteLine(true); break;
                case '/': System.Console.WriteLine(true); break;
                case '%': System.Console.WriteLine(true); break;
                default: System.Console.WriteLine(false); break;
            }
        }
         public void Problem5_16()
        {
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 0: System.Console.WriteLine("nol"); break;
                case 1: System.Console.WriteLine("bir"); break;
                case 2: System.Console.WriteLine("ikki"); break;
                case 3: System.Console.WriteLine("uch"); break;
                case 4: System.Console.WriteLine("to'rt"); break;
                case 5: System.Console.WriteLine("besh"); break;
                case 6: System.Console.WriteLine("olti"); break;
                case 7: System.Console.WriteLine("yetti"); break;
                case 8: System.Console.WriteLine("sakkiz"); break;
                case 9: System.Console.WriteLine("to'qqiz"); break;
                default: System.Console.WriteLine("boshqa"); break;
            }
        }
         public void Problem5_17()
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if(hours <= 0 && min - 45 < 0)
            {
                hours = 24 - 1;
                min = min + 60 - 45;
            }
            else if(min - 45 < 0)
            {
                hours -= 1;
                min = min + 60 - 45;
            }
            Console.WriteLine($"{hours} {min}");
            
        }
         public void Problem5_18()
        {
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine((num / 100 % 10 < 5 ? (num / 1000) * 1000 : (num / 1000 + 1) * 1000));
        }
         public void Problem5_19()
        {
            char ch = char.Parse(Console.ReadLine());
            if(ch >= 'a' && ch <= 'z')
            {
                System.Console.WriteLine(1);
            }
            else if(ch >= 'A' && ch <= 'Z')
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }
        public void Problem5_20()
        {
            char b;
            b =Convert.ToChar( Console.ReadLine());
            if ((b >= 65 && b <= 90) || (b >= 'a' && b <= 'z')) Console.WriteLine(1);
            else Console.WriteLine(0);
            Console.Read();
        }
        public void Problem5_21()
        {
           int son;
            son=Convert.ToInt32(Console.ReadLine());
            if (son % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
           
            Console.Read();
        }
                
    }
}