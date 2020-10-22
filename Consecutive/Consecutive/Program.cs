using System;
using System.Collections.Generic;
using System.Linq;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers separated by hyphens: ");
            var userEntry = Console.ReadLine();
            
            if (String.IsNullOrEmpty(userEntry))
            {
                Environment.Exit(0);
            }

            string[] entryArray = userEntry.Split('-');
            List<int> numberList = new List<int>();
            bool consecutive = true;
            bool duplicates = false;


            foreach (var num in entryArray)
            {
                numberList.Add(Convert.ToInt32(num));
            }

            numberList.Sort();

            int initialValue = numberList[0];

            foreach (var num in numberList)
            {
                if (numberList.IndexOf(num) != numberList.LastIndexOf(num))
                {
                    duplicates = true;
                    break;
                }
            }

            for (int i = 0; i < numberList.Count(); i++)
            {
                if (initialValue + i != numberList[i])
                {
                    consecutive = false;
                    break;
                }
            }
            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else if (!consecutive && duplicates)
            {
                Console.WriteLine("Not Consecutive with duplicates");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

    }
}
