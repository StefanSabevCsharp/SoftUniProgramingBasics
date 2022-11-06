using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double hours = int.Parse(Console.ReadLine());
            double minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes >= 45)
            {
                hours += 1;
            }
            if (minutes > 60)
            {
                minutes = minutes - 60;
            }
            //Console.WriteLine($"{hours}:{minutes}");
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
