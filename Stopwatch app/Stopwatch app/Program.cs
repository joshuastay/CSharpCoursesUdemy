using System;

namespace Stopwatch_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            string command;

            while (true)
            {
                Console.WriteLine("Enter a stopwatch command:");
                command = Console.ReadLine();
                if (command == "start")
                {
                    timer.Start();
                }
                else if (command == "stop")
                {
                    timer.Stop();
                }
                else if (command == "duration")
                {
                    Console.WriteLine(timer.Duration()); ;
                }
                else if (command == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid command");
                }

            }
        }
    }
}
