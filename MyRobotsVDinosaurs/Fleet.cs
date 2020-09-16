using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Fleet : Army // (IS AN ARMY)
    {
        // member variables (HAS A)

        public List<Robot> robots = new List<Robot>();

        // constructor (SPAWN)

        public Fleet() // Contains list of 3 dinosaur objects
        {
            Console.Write("Enter the name of your first robot: ");
            string userInput = Console.ReadLine();
            Robot robot1 = new Robot(userInput);
            robots.Add(robot1);

            Console.Write("Enter the name of your second robot: ");
            userInput = Console.ReadLine();
            Robot robot2 = new Robot(userInput);
            robots.Add(robot2);

            Console.Write("Enter the name of your third robot: ");
            userInput = Console.ReadLine();
            Robot robot3 = new Robot(userInput);
            robots.Add(robot3);
        }

        // member methods (CAN DO)
    }
}
