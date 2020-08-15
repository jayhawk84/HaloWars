using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace Halo
{
    public class Spartans
    {
        public string TeamColor;
        public void StartingWeapon(string weaponToSpawnWith)
        {
            Console.WriteLine($"This is the ring planet Halo: You spawned with a {weaponToSpawnWith}.");
        }

        public virtual void TeamMission()
        {
            Console.WriteLine($"All Spartans are assembling into organized teams to move against the Covenant.");
        }

        public void Mission(string YourMission)
        {
            Console.WriteLine($"You are on {this.TeamColor} team.  Your objective is to {YourMission}.");
        }

                        
    }
}
