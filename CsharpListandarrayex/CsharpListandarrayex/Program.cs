using System;

namespace CsharpListandarrayex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Exercise #1

            var facebook = new FacebookLikes();
            string newLike;
            while (true)
            {
                Console.WriteLine("Enter a name: ");
                newLike = Console.ReadLine();
                if (String.IsNullOrEmpty(newLike))
                {
                    break;
                }
                facebook.UserLikes(newLike);
            }
            int numberOfLikes = facebook.GetLikes();

            if (numberOfLikes > 2)
            {
                Console.WriteLine(String.Format("{0}, {1} and {2} others like your post!",
                    facebook.likes[0], facebook.likes[1], facebook.GetLikes() - 2));
            }
            else if (numberOfLikes == 2)
            {
                Console.WriteLine(String.Format("{0} and {1} like your post!",
                    facebook.likes[0], facebook.likes[1]));
            }
            else if (numberOfLikes == 1)
            {
                Console.WriteLine(String.Format("{0} likes your post!",
                    facebook.likes[0]));
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine();

            // Program exercise #2

            Console.WriteLine("Type Your Name: ");
            string username = Console.ReadLine();
            int lengthUser = username.Length;
            char[] nameArray = new char[lengthUser];
            foreach (char letter in username)
            {
                nameArray[username.IndexOf(letter)] = letter;
            }
            Array.Reverse(nameArray);
            Console.WriteLine(nameArray);

            Console.WriteLine();

            //Program exercise #3

            string[] fiveNums;
            bool numMatch = false;
            while (true)
            {
                numMatch = false;
                Console.WriteLine("Enter 5 numbers: ");
                var newnums = Console.ReadLine();
                fiveNums = newnums.Split(' ', 5);
                foreach (var n in fiveNums)
                {
                    if (Array.IndexOf(fiveNums, n) != Array.LastIndexOf(fiveNums, n))
                    {
                        numMatch = true;
                    }
                }
                if (numMatch)
                {
                    Console.WriteLine("entered duplicates, try again!");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Array.Sort(fiveNums);
            foreach (var i in fiveNums)
            {
                Console.WriteLine(i);

            }
        }
    }
}
