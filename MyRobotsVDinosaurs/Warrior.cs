using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Warrior
    {
        // member variables (HAS A)

        public string name;
        public int health;
        public int energy;

        // constructor (SPAWN)

        public Warrior(string name)
        {
            this.name = name;
            health = 100;
            energy = 100;
        }

        // member methods (CAN DO)

        public virtual void Attack(Warrior warrior)
        {
            Console.WriteLine($"{0} attacks {warrior}!", name);
        }
    }
}
