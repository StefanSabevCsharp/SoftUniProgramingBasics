using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000
            double duljina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double obem = duljina * shirochina * visochina;
            double liters = obem * 0.001;
            double percentzaet = percent * 0.01;
            double totalliters = liters * (1 - percentzaet);
            Console.WriteLine(totalliters);


        }
    }
}
