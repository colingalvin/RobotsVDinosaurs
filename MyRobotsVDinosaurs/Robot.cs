using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Robot : Warrior // (IS A WARRIOR)
    {
        // member variables (HAS A)

        public Weapon weapon;

        // constructor (SPAWN)

        public Robot(string name)
            :base(name)
        {
            Console.WriteLine($"Weapons:\n  1) Sword (attack power 5)\n  2) Battle Axe (attack power 10)");
            Console.Write("Choose your weapon: ");
            string userInput = Console.ReadLine();
            string validUserInput = Verification.VerifySwitchCase(userInput, 1, 2);
            Console.WriteLine();
            switch(validUserInput)
            {
                case "1":
                    weapon = new Weapon("Sword", 5);
                    break;
                case "2":
                    weapon = new Weapon("Battle Axe", 10);
                    break;
            }
        }

        // member methods (CAN DO)

        public override void Attack(Warrior warrior)
        {
            warrior.health -= weapon.attackPower;
            energy -= 10;
        }
    }
}
