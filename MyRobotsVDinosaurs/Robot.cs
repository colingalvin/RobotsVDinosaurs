using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Robot
    {
        // member variables

        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        // constructor

        public Robot()
        {
            name = "Terminator";
            health = 100;
            powerLevel = 100;
            Console.WriteLine($"Weapons:\n  1) Sword (attack power 10)\n  2) Battle Axe (attack power 15)");
            Console.Write("Choose your weapon: ");
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    weapon = new Weapon("Sword", 10);
                    break;
                case "2":
                    weapon = new Weapon("Battle Axe", 15);
                    break;
            }
        }

        // member methods

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
            powerLevel -= 10;
        }
    }
}
