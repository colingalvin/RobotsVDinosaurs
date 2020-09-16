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

        // constructor (SPAWN)

        public Warrior(string name)
        {
            this.name = name;
        }

        // member methods (CAN DO)

        public virtual void Attack(Warrior warrior)
        {
            Console.WriteLine($"{0} attacks {warrior}!", name);
        }
    }
}
