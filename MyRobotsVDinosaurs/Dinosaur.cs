using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Dinosaur
    {
        // member variables

        public string type;
        public int health;
        public int energy;
        public int attackPower;

        // constructor

        public Dinosaur()
        {
            type = "TRex";
            health = 100;
            energy = 100;
            // attackPower = 10; (No longer necessary - attack power chosen from list of attacks)
        }

        // member methods

        public void Attack(Robot robot)
        {
            Console.WriteLine($"Attacks:\n  1) Bite (deals 10 damage)\n  2) Stomp (deals 5 damage)");
            Console.Write("Choose your attack: ");
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    robot.health -= 10;
                    energy -= 10;
                    break;
                case "2":
                    robot.health -= 5;
                    energy -= 10;
                    break;
            }
        }
    }
}
