using System;
using System.Threading.Tasks;

namespace bootcamp
{

    class Program
    {  
        static async Task MakingTable()
        {
            Console.WriteLine("Making Table..");
            await Task.Delay(5000);
            Console.WriteLine("Table is Ready!");
        }
        static async Task MakingTea()
        {
            Console.WriteLine("Making Tea..");
            await Task.Delay(3000);
            Console.WriteLine("Tea is Ready!");
        }
        static async Task MakingEggs()
        {
            Console.WriteLine("Making Eggs..");
            await Task.Delay(7000);
            Console.WriteLine("Eggs are Ready!");
        }
    
        static async Task Main()
        {

            Console.WriteLine("Good Morning");
            var tasks = new Task[] { MakingEggs(), MakingTable(),MakingTea() };

            var all = Task.WhenAll(tasks);
            await all;

            System.Console.WriteLine("Bon appetito!");
       
        }


    }

}