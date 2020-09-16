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

        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        // constructor (SPAWN)

        public Herd() // Contains list of 3 dinosaur objects
        {
            Console.Write("Enter the name of your first dinosaur: ");
            string userInput = Console.ReadLine();
            Dinosaur dinosaur1 = new Dinosaur(userInput);
            dinosaurs.Add(dinosaur1);

            Console.Write("Enter the name of your second dinosaur: ");
            userInput = Console.ReadLine();
            Dinosaur dinosaur2 = new Dinosaur(userInput);
            dinosaurs.Add(dinosaur2);

            Console.Write("Enter the name of your third dinosaur: ");
            userInput = Console.ReadLine();
            Dinosaur dinosaur3 = new Dinosaur(userInput);
            dinosaurs.Add(dinosaur3);
        }

        // member methods (CAN DO)
    }
}
