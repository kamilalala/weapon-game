using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sword : Weapon
    {
        public bool ranged = false;

        public void SFX()
        {
            Console.WriteLine(""); 
            Console.WriteLine("C L I N K !!!!!!!!!!!!!!");
        }
    }
}
