using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentforHall = double.Parse(Console.ReadLine());
            double cake = rentforHall * 0.2;
            double drinks = cake - (cake * 0.45);
            double animator = rentforHall / 3;
            double totalsum = rentforHall + cake + drinks + animator;
            Console.WriteLine(totalsum);
//            •	Торта  – цената ѝ е 20 % от наема на залата
//•	Напитки – цената им е 45 % по - малко от тази на тортата
//•	Аниматор – цената му е 1 / 3 от цената за наема на залата

        }
    }
}
