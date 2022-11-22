using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int chasove = 3;
                int proekti = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {proekti * chasove } hours to complete {proekti} project/s.");
        }
        
    }
}
