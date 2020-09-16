using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Fleet
    {
        // member variables

        public List<Robot> robots = new List<Robot>();

        // constructor

        public Fleet() // Contains list of 3 dinosaur objects
        {
            Robot robot1 = new Robot();
            robots.Add(robot1);
            Robot robot2 = new Robot();
            robots.Add(robot2);
            Robot robot3 = new Robot();
            robots.Add(robot3);
        }

        // member methods
    }
}
