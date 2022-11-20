using System;

namespace InchToSM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, 
            //    която чете от конзолата число(реално число) и
            //    преобразува числото от инчове в сантиметри.
            //    За целта умножава инчовете по 2.54(защото 1 инч = 2.54 сантиметра).
            double chete = double.Parse(Console.ReadLine  ());
            Console.WriteLine(chete * 2.54);

        }

    }
}
