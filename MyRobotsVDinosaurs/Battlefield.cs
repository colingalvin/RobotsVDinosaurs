using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Battlefield
    {
        // member variables (HAS A)

        public Herd herd;
        public Fleet fleet;

        // constructor (SPAWN)

        public Battlefield()
        {
            Console.Write("Name your herd of dinosaurs: ");
            string userInput = Console.ReadLine();
            herd = new Herd(userInput);

            Console.Write("Name your fleet of robots: ");
            userInput = Console.ReadLine();
            fleet = new Fleet(userInput);
        }

        // member methods (CAN DO)

        public void DoBattle()
        {
            do
            {
                Console.WriteLine($"{herd.name} attack first!");
                // army chooses who to attack
                Console.WriteLine($"{fleet.name} attack next!");
            }
            while ((herd.warriors[0].health > 0 || herd.warriors[1].health > 0 || herd.warriors[2].health > 0) && (fleet.warriors[0].health > 0 || fleet.warriors[1].health > 0 || fleet.warriors[2].health > 0));
            EndGame();
        }

        public void EndGame()
        {
            Console.WriteLine("Battle has concluded.");
        }
    }
}
