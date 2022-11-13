using System;

namespace FruitShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;
            double total = 0;

            if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
            {
                Console.WriteLine("error");
                return;
            }
            if (fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes")
            {
                Console.WriteLine("error");
                return;
            }
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    banana = 2.50;
                    apple = 1.2;
                    orange = 0.85;
                    grapefruit = 1.45;
                    kiwi = 2.70;
                    pineapple = 5.5;
                    grapes = 3.85;
                    break;
                case "Saturday":
                case "Sunday":
                    banana = 2.70;
                    apple = 1.25;
                    orange = 0.90;
                    grapefruit = 1.6;
                    kiwi = 3;
                    pineapple = 5.6;
                    grapes = 4.2;
                    break;
                default:
                    break;
            }
            switch (fruit)
            {
                case "banana":
                    total = banana * quantity;
                    break;
                case "apple":
                    total = apple * quantity;
                    break;
                case "orange":
                    total = orange * quantity;
                    break;
                case "grapefruit":
                    total = grapefruit * quantity;
                    break;
                case "kiwi":
                    total = kiwi * quantity;
                    break;
                case "pineapple":
                    total = pineapple * quantity;
                    break;
                case "grapes":
                    total = grapes * quantity;
                    break;
                    

                default:
                    break;
            }
            Console.WriteLine($"{total:f2}");

        }
    }
}
