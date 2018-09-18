using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var raffle = new Raffle();
            Console.WriteLine("Reading...");
            raffle.ReadDataFile("Data.txt");
            foreach (var participant in raffle.Participants)
            {
                Console.WriteLine(participant);
            }
            Console.WriteLine($"Count: {raffle.CountOfParticipants}");
            Console.WriteLine("Press any key to pick a winner!");
            Console.ReadKey();
            raffle.PickWinner();
            Console.WriteLine($"Winner: {raffle.Winner}");
            Console.ReadLine();
        }
    }
}
