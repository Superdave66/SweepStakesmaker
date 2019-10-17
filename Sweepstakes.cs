using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant > sweepstakesContestants = new Dictionary<int, Contestant>();
        string name;
        int key;
        int registrationnum;
        int winner;

        public Sweepstakes(string name)
        {
            Console.WriteLine("what do you want the Sweepstakes name to be?");
            name = Console.ReadLine();
        }
        void RegisterContestant(Contestant contestant)
        {
            int x;
            int y;
            Console.WriteLine("how many contestants do you want?");
            y = int.Parse(Console.ReadLine());
            for (x = 0; x < y; x++)
            {
                registrationnum = sweepstakesContestants.Count + 1;
                contestant.RegistrationNumber = registrationnum;
                sweepstakesContestants.Add(registrationnum, contestant);
            }
        }

        public  Contestant PickWinner()
        {
            Random random = new Random();
            winner = random.Next( 1, sweepstakesContestants.Count);
            Console.WriteLine(winner);



        }
            void PrintWinningContestantInfo(Contestant contestant)
        {
            bool TryGetValue(int winner, out TValue value);

        }
    }
}
