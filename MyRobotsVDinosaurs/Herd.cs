using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Herd : Army // (IS AN ARMY)
    {
        // member variables (HAS A)

        // constructor (SPAWN)

        public Herd(string name) // Contains list of 3 dinosaur objects
            :base(name)
        {
            Console.Write("Enter the name of your first dinosaur: ");
            string userInput = Console.ReadLine();
            Dinosaur dinosaur1 = new Dinosaur(userInput);
            warriors.Add(dinosaur1);

            Console.Write("Enter the name of your second dinosaur: ");
            userInput = Console.ReadLine();
            Dinosaur dinosaur2 = new Dinosaur(userInput);
            warriors.Add(dinosaur2);

            Console.Write("Enter the name of your third dinosaur: ");
            userInput = Console.ReadLine();
            Dinosaur dinosaur3 = new Dinosaur(userInput);
            warriors.Add(dinosaur3);
        }

        // member methods (CAN DO)

    }
}
