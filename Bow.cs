using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bow : Weapon
    {
        public bool ranged = true;

        public void SFX()
        {
            Console.WriteLine("");
            Console.WriteLine("F L L L I N G !!!!!");
        }
    }
}
