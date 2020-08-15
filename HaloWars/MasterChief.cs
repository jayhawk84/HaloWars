using System;
using System.Collections.Generic;
using System.Text;

namespace Halo
{
    class MasterChief : Spartans
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome, Master Chief.");
        }

        public override void TeamMission()
        {
            Console.WriteLine("You are not on a team.  You are on your own.");
        }

        public void MasterChiefMission()
        {
            Console.WriteLine("You need to kill everything that is not a member of our teams.");
        }
    }
}
