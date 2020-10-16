using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Program
            Console.WriteLine("Enter a number between 1 and 10");
            Console.WriteLine(Between1and10.Between(Convert.ToInt32(Console.ReadLine())));

            // Second Program
            var findMax = new MaxNumber();
            Console.WriteLine("Enter first number: ");
            findMax.number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            findMax.number2 = Convert.ToInt32(Console.ReadLine());

            findMax.BiggerNumber();

            // Third Program
            var picture = new Orientation();

            picture.CheckOrient();

            // Fourth Program
            var fastCheck = new SpeedCamera();
            fastCheck.speedLimit = 65;

            while (true)
            {
                Console.WriteLine("Enter Speed: ");
                fastCheck.CheckSpeed(Convert.ToInt32(Console.ReadLine()));
            }

        }
    }
}
