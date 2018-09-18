using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public class Raffle
    {
        private Random randomGenerator = new Random();

        private List<string> participants = new List<string>();

        public int CountOfParticipants
        {
            get
            {
                return participants.Count;
            }
        }

        public IReadOnlyList<string> Participants
        {
            get
            {
                return participants;
            }
        }

        public string Winner { get; private set; }

        public void ReadDataFile(string filename)
        {
            participants.Clear();
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    participants.Add(line);
                }
            }
        }

        public void PickWinner()
        {
            var index = randomGenerator.Next(CountOfParticipants);
            Winner = participants[index];
        }
    }
}
