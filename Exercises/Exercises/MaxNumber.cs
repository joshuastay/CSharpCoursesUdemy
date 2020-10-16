using System;

namespace Exercises
{
    public class MaxNumber
    {
        public int number1;
        public int number2;

        public void BiggerNumber()
        {
            Console.WriteLine(String.Format("The maximum of the two numbers is {0}", (number1 > number2) ? number1 : number2));
        }
    }
}
