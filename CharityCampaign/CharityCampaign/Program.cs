using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]
            var campaingDays = int.Parse(Console.ReadLine());
            var cookers = int.Parse(Console.ReadLine());
            var cakes = int.Parse(Console.ReadLine());
            var waffles = int.Parse(Console.ReadLine());
            var pancackes = int.Parse(Console.ReadLine());
            // Prices
            double cakeprice = cakes * 45;
            double waffleprice = waffles *5.8;
            double pancakeprice = pancackes *3.2;
            //Calculations
            double pricepercoockerperday = cakeprice + waffleprice + pancakeprice;
            double priceperallcoockersperday = pricepercoockerperday * cookers;
            double totalcampaingsum = priceperallcoockersperday * campaingDays;
            double totalsumafterexpenses = totalcampaingsum - (totalcampaingsum / 8);
            Console.WriteLine(totalsumafterexpenses);


        }
    }
}
