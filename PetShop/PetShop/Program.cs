﻿using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета.
            //    Храната се пазарува основно за кучета, от зоомагазин, но понякога стопанинът
            //    им купува и за животните на съседа му.
            //    Една опаковка храна за кучета е на цена 2.50лв.,
            //    а всяка друга, която не е за тях струва 4лв.        }
            //            От конзолата се четат 2 реда:
            //            1.Броят на кучетата – цяло число в интервала[0… 100]
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            double kucheta = double.Parse(Console.ReadLine());
            int jivotni = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(kucheta * 2.50) + (jivotni * 4)} lv.");

        }
    }
}
