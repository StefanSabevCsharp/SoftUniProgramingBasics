using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            double votingMembers = double.Parse(Console.ReadLine());

            for (int i = 1; i <= votingMembers; i++)
            {
                string nameOfVotingMember = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());
                pointsFromAcademy += (nameOfVotingMember.Length * pointsGiven) / 2;
                if (pointsFromAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:f1}!");
                    return;
                }

            }
            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsFromAcademy} more!");
        }
    }
}
