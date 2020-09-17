using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Dinosaur : Warrior // (IS A WARRIOR)
    {
        // member variables (HAS A)

        public string type;

        // constructor (SPAWN)

        public Dinosaur(string name)
            :base(name) // Runs base constructor with name input, returns to finish constructing rest of dinosaur
        {
            type = "TRex";
            // attackPower = 10; (No longer necessary - attack power chosen from list of attacks)
        }

        // member methods (CAN DO)

        public override void Attack(Warrior warrior)
        {
            Console.WriteLine($"Attacks:\n  1) Bite (deals 10 damage)\n  2) Stomp (deals 5 damage)");
            Console.Write("Choose your attack: ");
            string userInput = Console.ReadLine();
            string validUserInput = Verification.VerifySwitchCase(userInput, 1, 2);
            switch (validUserInput)
            {
                case "1":
                    warrior.health -= 10;
                    energy -= 10;
                    // Console.WriteLine($"{name} attacks {warrior.name} for 10 damage!");
                    break;
                case "2":
                    warrior.health -= 5;
                    energy -= 10;
                    // Console.WriteLine($"{name} attacks {warrior.name} for 5 damage!");
                    break;
            }
        }
    }
}
