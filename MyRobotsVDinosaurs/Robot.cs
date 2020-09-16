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
            weapon = new Weapon();
        }

        // member methods
    }
}
