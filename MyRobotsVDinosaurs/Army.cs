using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Army
    {
        // member variables (HAS A)

        public string name;
        public List<Warrior> warriors;

        // constructor (SPAWN)

        public Army(string name)
        {
            this.name = name;
            warriors = new List<Warrior>();
        }

        // member methods (CAN DO)

        public Warrior ChooseAttacker(Army army) // select from available list of warriors
        {
            Warrior chosenWarrior;
            bool hasEnergy = false;
            do
            {
                DisplayAvailableWarriors(army); // Pass in attacker army, display list of available warriors that can attack
                string userInput = Console.ReadLine();
                int validUserInput = int.Parse(Verification.VerifySwitchCase(userInput, 1, army.warriors.Count));
                chosenWarrior = army.warriors[validUserInput - 1];
                hasEnergy = Verification.IsWarriorAlive(chosenWarrior, hasEnergy); // Verify attacker has energy to attack
            }
            while (hasEnergy == false);
            return chosenWarrior;
        }

        public Warrior ChooseOpponent(Army army) // select from available list of warriors
        {
            DisplayAvailableWarriors(army); // Pass in attacker army, display list of available warriors that can attack
            string userInput = Console.ReadLine();
            int validUserInput = int.Parse(Verification.VerifySwitchCase(userInput, 1, army.warriors.Count));
            Warrior chosenWarrior = army.warriors[validUserInput - 1];
            return chosenWarrior;
        }

        public void DisplayAvailableWarriors(Army army) // Takes in army
        {
            int i = 1;
            foreach(Warrior warrior in army.warriors) // Iterates through warriors in army
            {
                Console.WriteLine($"  {i}) {warrior.name}"); // Writes available warriors
                i++;
            }
        }

        public void CheckForDead()
        {
            foreach(Warrior warrior in warriors.ToList()) // Exception thrown when removed from list
            {
                if(warrior.health <= 0)
                {
                    Console.WriteLine($"\n{warrior.name} has been killed!");
                    warriors.Remove(warrior);
                    Console.WriteLine("Press enter to continue the game");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
