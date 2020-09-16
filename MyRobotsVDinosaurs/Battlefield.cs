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

            Console.Write($"\nName your fleet of robots: ");
            userInput = Console.ReadLine();
            fleet = new Fleet(userInput);
        }

        // member methods (CAN DO)

        public void DoBattle()
        {
            do
            {
                DisplayGameStats();
                Console.WriteLine($"\n{herd.name}, attack!"); // Dinosaurs attack first

                Console.WriteLine($"\nChoose which dinosaur will attack:");
                Warrior attacker = herd.ChooseOpponent(herd); // Displays remaining dinosaurs able to attack
                Console.WriteLine($"\nChoose who {attacker.name} will attack:");
                Warrior defender = herd.ChooseOpponent(fleet); // Displays remaining robots able to be attacked
                attacker.Attack(defender); // Runs specific attack to each warrior type

                DisplayGameStats();
                Console.WriteLine($"\n{fleet.name}, attack!"); // Robots attack second

                Console.WriteLine($"\nChoose which robot will attack:"); // Same as above
                attacker = fleet.ChooseOpponent(fleet);
                Console.WriteLine($"\nChoose who {attacker.name} will attack:");
                defender = fleet.ChooseOpponent(herd);
                attacker.Attack(defender);
            }
            // loop while any team has a member that is alive
            while ((herd.warriors[0].health > 0 || herd.warriors[1].health > 0 || herd.warriors[2].health > 0) && (fleet.warriors[0].health > 0 || fleet.warriors[1].health > 0 || fleet.warriors[2].health > 0));
            EndGame();
        }

        public void DisplayGameStats()
        {
            Console.Clear();
            Console.WriteLine("Current stats:\nDinosaurs:");
            foreach(Warrior warrior in herd.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
            Console.WriteLine("\nRobots:");
            foreach (Warrior warrior in fleet.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
        }

        public void EndGame()
        {
            Console.WriteLine("Battle has concluded.");
        }
    }
}
