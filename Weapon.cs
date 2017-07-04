using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Weapon
    {
        protected string name;
        public int damage;
        public float sharpness;

        public void printInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Sharpness: " + sharpness);
        }

        public void getName()
        {
            name = Console.ReadLine();
        }

        public static void ChooseWeapon()
        {
            bool wellChosen = false;
            int weaponChoice;

            while (!wellChosen)
            {
            Console.WriteLine("Welcome, traveller.");
            Console.WriteLine("Pick your weapon of choice: ");
            Console.WriteLine("1. Mace");
            Console.WriteLine("2. Sword");
            Console.WriteLine("3. Bow");
            weaponChoice = Convert.ToInt32(Console.ReadLine());


            switch (weaponChoice)
            {
                case 1:

                    wellChosen = true;
                    Console.Clear();
                    Mace mace = new Mace();
                    mace.damage = 5775;

                    Console.WriteLine("Very Well.");
                    Console.Write("Enter a name for the mace: ");
                    mace.getName();
                    mace.SFX();
                    mace.sharpness = 3.2f;
                    mace.printInfo();
                    break;

                case 2:

                    wellChosen = true;
                    Console.Clear();
                    Sword sword = new Sword();
                    sword.damage = 2900;

                    Console.WriteLine("Exquisite.");
                    Console.Write("Enter a name for the sword: ");
                    sword.getName();
                    sword.SFX();
                    sword.sharpness = 7.9f;
                    sword.printInfo();
                    break;

                case 3:

                    wellChosen = true;
                    Console.Clear();
                    Bow bow = new Bow();
                    bow.damage = 2900;

                    Console.WriteLine("Delightful.");
                    Console.Write("Enter a name for the sword: ");
                    bow.getName();
                    bow.SFX();
                    bow.sharpness = 7.9f;
                    bow.printInfo();
                    break;

                default :
                    Console.WriteLine("Pick a valid option you fool!");
                    break;
            }
            }
        }
    }
}
