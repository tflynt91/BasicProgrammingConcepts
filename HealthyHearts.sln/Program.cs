using System;

namespace HealthyHearts.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int maxHeartRate = 220 - age;
            Console.WriteLine("Your maximum heart rate should be {0} beats per minute.", maxHeartRate);
            Console.WriteLine("Your target HR Zone is {0} - {1} beats per minute.", maxHeartRate * .5, maxHeartRate * .85);

        }
    }
}
