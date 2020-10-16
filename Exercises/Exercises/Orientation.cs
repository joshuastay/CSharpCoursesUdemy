using System;

namespace Exercises
{
    public class Orientation
    {
        public int width;
        public int height;

        public void GetWidth()
        {
            Console.WriteLine("Enter width of image: ");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public void GetHeight()
        {
            Console.WriteLine("Enter height of image: ");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void CheckOrient()
        {
            GetWidth();
            GetHeight();
            if (width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("The image is a portrait");
            }
            else
            {
                Console.WriteLine("The image is square");
            }

        }
    }
}
