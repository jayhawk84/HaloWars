using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Halo
{
    public class Scout : Spartans
    {
        public void GoScout(string whatToLookFor = "grunts")
        {
            Console.WriteLine($"You need to be on the lookout for {whatToLookFor}");
        }
        

    }
}
