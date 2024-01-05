using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2Y_2324_OOP_Async
{
    internal class Program
    {
        static Random rnd = new Random();   
        static async Task Main(string[] args)
        {
            //Worker(1, 1000, 10);
            //Worker(2, 500, 20);
            //Worker(3, 400, 30);

            WorkerAsync(1, 1000, 10);
            WorkerAsync(2, 500, 20);
            WorkerAsync(3, 400, 30);

            Console.ReadKey();
        }

        static void Worker(int ID, int taskDuration, int workTime)
        {
            Console.WriteLine($"Worker {ID} has begun to work!");

            for(int x = 0; x < workTime; x++) 
            {
                Thread.Sleep(taskDuration);
                Console.WriteLine($"Worker {ID} has finished task {x + 1}!");
            }

            Console.WriteLine($"Worker {ID} has finished working!");
        }

        static async Task WorkerAsync(int ID, int taskDuration, int workTime)
        {
            switch(ID)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }


            Console.WriteLine($"Worker {ID} has begun to work!");

            for (int x = 0; x < workTime; x++)
            {
                await Task.Delay(rnd.Next(200,1500));
                //await VisualDelay(taskDuration);
                switch (ID)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
                Console.WriteLine($"Worker {ID} has finished task {x + 1}!");
            }

            switch (ID)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            Console.WriteLine($"Worker {ID} has finished working!");
        }

        static async Task VisualDelay(int duration)
        {
            Console.WriteLine("Start the delay");

            for(int x = 0; x < duration; x++)
            {
                Console.WriteLine("...");
            }    

            Console.WriteLine("Delay finished");
        }
    }
}
