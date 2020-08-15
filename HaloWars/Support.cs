using System;
using System.Collections.Generic;
using System.Text;

namespace Halo
{
    class Support : Spartans
    {
        public void GiveSupport(string whatToShootAt = "jackals")
        {
            Console.WriteLine($"Make sure you cover Master Chief.  If he is ok, then shoot {whatToShootAt}");
        }
    }
}
