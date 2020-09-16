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
            attackPower = 10;
        }

        // member methods

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
        }
    }
}
