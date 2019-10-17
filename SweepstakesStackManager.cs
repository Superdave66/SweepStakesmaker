using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop(); 
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
