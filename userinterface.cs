using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
     
        
        
        public static void CreateContestant(Contestant contestant)
        {   
            Console.WriteLine("What is your first name?");
            contestant.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            contestant.LastName = Console.ReadLine();
            Console.WriteLine("what is your email address");
            contestant.Emailaddress = Console.ReadLine();
        
         
        }       
    }

       
    
}
