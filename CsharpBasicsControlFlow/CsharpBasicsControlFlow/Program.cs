using System;
using System.Xml.Schema;

namespace CsharpBasicsControlFlow
{
    class Program
    {
        public class GuessTheNumber
        {
            private int hiddenNumber;
            public Random rand = new Random();
            private int tries;

            public void StartGame()
            {
                hiddenNumber = rand.Next(1, 10);
                tries = 4;
                int guess;

                do
                {
                    Console.WriteLine("Guess My Number 1 to 10: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (PlayerGuess(guess))
                    {
                        Console.WriteLine("You Win!");
                        break;
                    }
                    Console.WriteLine("Wrong number");
                    tries--;
                } while (tries > 0);

                if (tries == 0)
                {
                    Console.WriteLine("You Lost");
                }

            }

            private bool PlayerGuess(int number)
            {
                if (number == hiddenNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            var check3Factor = new DivisibleBy3();

            for (var i = 0; i <= 100; i++)
            {
                check3Factor.CheckDiv3(i);
            }
            Console.WriteLine(check3Factor.count);

            var addNums = new AddUserNmbers();

            while (true)
            {
                Console.Write("Enter a Number or OK to exit: ");
                var input = Console.ReadLine();

                if (input == "OK")
                {
                    break;
                }

                addNums.AddToNums(Convert.ToInt32(input));
                Console.WriteLine(addNums.totalNums);

            }

            Console.WriteLine("Compute Factorial of: ");
            var numToFactorial = Convert.ToInt32(Console.ReadLine());
            FactorialCalc.CalculateFactorial(numToFactorial);

            var game = new GuessTheNumber();
            game.StartGame();
        }

    }
}
