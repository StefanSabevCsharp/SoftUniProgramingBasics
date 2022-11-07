using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string webpage = Console.ReadLine();
            for (int i = 1; i <+ tabs; i++)
            {
                switch (webpage)
                {
                    case"Facebook":
                        salary -= 150;
                        break;
                    case"Instagram":
                        salary -= 100;
                        break;
                    case"Reddit":
                        salary -= 50;
                        break;
                    
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                webpage = Console.ReadLine();
            }
            Console.WriteLine(salary);
        }
    }
}
