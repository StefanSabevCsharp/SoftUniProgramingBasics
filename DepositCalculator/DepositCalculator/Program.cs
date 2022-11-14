using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposid = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double annualpercent = double.Parse(Console.ReadLine());

            //Matematika

            double annualdeposit = deposid * annualpercent;
            Console.WriteLine(annualdeposit);
        }
    }
}
