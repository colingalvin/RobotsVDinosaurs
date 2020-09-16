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

        public virtual Warrior ChooseOpponent(Army army) // select from available list of warriors
        {
            DisplayAvailableWarriors(army); // Pass in attacker army, display list of available warriors that can attack
            int userInput = int.Parse(Console.ReadLine());
            Warrior chosenWarrior = army.warriors[userInput-1];
            return chosenWarrior;
        }

        public virtual void DisplayAvailableWarriors(Army army) // Takes in army
        {
            int i = 1;
            foreach(Warrior warrior in army.warriors) // Iterates through warriors in army
            {
                Console.WriteLine($"  {i}) {warrior.name}"); // Writes available warriors
                i++;
            }
        }

    }
}
