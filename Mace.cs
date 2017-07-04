using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mace : Weapon
    {
        public bool ranged = false;

        public void SFX()
        {
            Console.WriteLine("");
            Console.WriteLine("C R U S S S H !!!!!");
        }
    }
}
