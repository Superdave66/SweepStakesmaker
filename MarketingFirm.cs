using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm : ISweepstakesManager
    {
        int manageType;
        public void getManageType()
        {
            Console.WriteLine("type 1 for queue manager or type 2 for stack manager");

            manageType = int.Parse(Console.ReadLine());
            if (manageType == 1)
            {
                
                    
            }
            else if (manageType == 2)
            {
                
              
            }
            else
            { 
                Console.WriteLine("you did not put in a valid input please try again");
                getManageType();
            }
        }
     
    }
}
