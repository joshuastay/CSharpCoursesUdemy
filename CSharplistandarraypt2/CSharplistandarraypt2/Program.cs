using System;
using System.Collections.Generic;

namespace CSharplistandarraypt2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Exercise #4

            List<int> numberList = new List<int>();
            List<int> uniqueList = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type QUIT: ");
                var input = Console.ReadLine();
                if (input == "QUIT")
                {
                    break;
                }
                int number = Convert.ToInt32(input);
                numberList.Add(number);
                if (!uniqueList.Contains(number))
                {
                    uniqueList.Add(number);
                }
                Console.WriteLine();
                Console.Write("You have entered: ");
                foreach (var num in uniqueList)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine();

            }

            // Program Exercise #5

            List<int> numList = new List<int>();
            bool validList = false;
            string[] entryArray;
            do
            {
                Console.WriteLine("Enter a list of atleast 5 numbers separated by commas: ");
                var userEntry = Console.ReadLine();
                if (String.IsNullOrEmpty(userEntry))
                {
                    Console.WriteLine("List is empty, try again!");
                    continue;
                }
                else
                {
                    entryArray = userEntry.Split(',');

                    if (entryArray.Length < 5)
                    {
                        Console.WriteLine("List not long enough!");
                        continue;
                    }

                    foreach (var i in entryArray)
                    {
                        numList.Add(Convert.ToInt32(i.Trim()));
                    }
                    foreach (var n in numList)
                    {
                        Console.WriteLine(n);
                    }
                    validList = true;
                }
                
            } while (!validList);
            
        }
    }
}
