using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double gradus = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(gradus));
        }
    }
}
