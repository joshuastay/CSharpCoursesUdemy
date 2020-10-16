using System;

namespace CsharpBasicsControlFlow
{
    public class FactorialCalc
    {
        public static void CalculateFactorial(int number)
        {
            int totalFactorial = 1;

            for (var i = number; i >= 1; i--)
            {
                totalFactorial *= i;
            }

            Console.WriteLine(String.Format("{0}! = {1}", number, totalFactorial));
        }
    }
}
