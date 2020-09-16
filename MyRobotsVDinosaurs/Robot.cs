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

        public int health;
        public int powerLevel;
        public Weapon weapon;

        // constructor (SPAWN)

        public Robot(string name)
            :base(name)
        {
            health = 100;
            powerLevel = 100;
            Console.WriteLine($"Weapons:\n  1) Sword (attack power 10)\n  2) Battle Axe (attack power 15)");
            Console.Write("Choose your weapon: ");
            string userInput = Console.ReadLine();
            switch(userInput)
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

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
            powerLevel -= 10;
        }
    }
}
