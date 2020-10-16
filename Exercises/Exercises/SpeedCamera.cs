using System;

namespace Exercises
{
    public class SpeedCamera
    {
        public int speedLimit;
        public int totalDemerits = 0;
        public int demerits;

        public void CheckSpeed(int speed)
        {
            if (speed > speedLimit)
            {
                demerits = (speed - speedLimit) / 5 + 1;
                totalDemerits += demerits;
                Console.WriteLine(String.Format("Received {0} demerits. {1} demerits total.", demerits, totalDemerits));
            }
            else
            {
                Console.WriteLine("Good Speed, No Demerits");
            }
            if (totalDemerits > 12)
            {
                Console.WriteLine("License SUSPENDED");
                Environment.Exit(1);
            }
        }

    }
}
