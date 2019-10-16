using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        public static int regnum;
        
        
        public static void CreateContestant(Contestant contestant)
        {   
            Console.WriteLine("What is your first name?");
            contestant.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            contestant.LastName = Console.ReadLine();
            Console.WriteLine("what is your email address");
            contestant.Emailaddress = Console.ReadLine();
            Console.WriteLine("your registration number is" + contestant.RegistrationNumber);
            contestant.RegistrationNumber = CreateRegistration( ) ;


        }

        
        public static int CreateRegistration()
        {
            
             regnum=0;
            if (regnum < 10000) 
            {
                regnum ++;
            }
        }

       
    }
}
