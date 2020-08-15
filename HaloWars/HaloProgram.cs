using System;

namespace Halo
{
    class HaloProgram
    {
        static void doWork()
        {
            Console.WriteLine("Welcome, Spartan.");
            Scout RedScout = new Scout();
            RedScout.StartingWeapon("Sniper Rifle");
            RedScout.TeamColor = "red";
            RedScout.TeamMission();
            RedScout.Mission("help the other scouts");
            RedScout.GoScout();
            Console.WriteLine();

            MasterChief John117 = new MasterChief();
            John117.Welcome();
            John117.StartingWeapon("Assault Rifle");
            John117.TeamMission();
            John117.MasterChiefMission();
            Console.WriteLine();

            Console.WriteLine("Welcome, Spartan.");
            Support YellowSpartan = new Support();
            YellowSpartan.StartingWeapon("Battle Rifle");
            YellowSpartan.TeamColor = "yellow";
            YellowSpartan.TeamMission();
            YellowSpartan.Mission("take out enemy scouts");
            YellowSpartan.GiveSupport();
            

        }
        
        static void Main(string[] args)
        {
            try 
            {
                doWork();
            }
            catch
            {
                throw new NotImplementedException();
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Spartans, you live to die another day.");
            }
        }
    }
}
