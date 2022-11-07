using System;

namespace MountingTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double groups = double.Parse(Console.ReadLine());
            double Musala = 0;
            double Monbland = 0;
            double Kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double people = 0;
            for (int i = 1; i <= groups; i++)
            {
                double members = double.Parse(Console.ReadLine());
                people += members;
                if (members <= 5)
                {
                    Musala += members;
                }
                if (members >= 6 && members <= 12)
                {
                    Monbland += members;
                }
                if (members >= 13 && members <= 25)
                {
                    Kilimandjaro += members;
                }
                if (members >= 26 && members <= 40)
                {
                    k2 += members;

                }
                if (members >= 41)
                {
                    everest += members;
                }

            }
            Console.WriteLine($"{(Musala / people) * 100:f2}%");
            Console.WriteLine($"{(Monbland / people) * 100:f2}%");
            Console.WriteLine($"{(Kilimandjaro / people) * 100:f2}%");
            Console.WriteLine($"{(k2 / people) * 100:f2}%");
            Console.WriteLine($"{(everest / people) * 100:f2}%");
        }
    }
}
