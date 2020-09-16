using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Weapon
    {
        // member variables

        public string type;
        public int attackPower;

        // constructor

        public Weapon(string userInput, int attackPower)
        {
            this.type = userInput;
            this.attackPower = attackPower;
        }

        // member methods
    }
}
