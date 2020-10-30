using System;
using System.IO;

namespace Working_with_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFile = File.ReadAllText(@"c:\filetoread.txt");
            var wordCount = 0;
            var letterCount = 0;
            string longWord = "";
            var longWordLength = 0;


            var textArray = textFile.Split();

            foreach (var word in textArray)
            {
                letterCount = word.Length;
                if (letterCount > longWordLength)
                {
                    longWordLength = letterCount;
                    longWord = word;
                }

                if (String.IsNullOrWhiteSpace(word))
                {
                    continue;
                }
                wordCount++;
            }
            Console.WriteLine("Total words in file: " + wordCount);
            Console.WriteLine("The longest word in the file is: " + longWord);
        }
    }
}
