using System;
using System.Collections.Generic;
using System.Globalization;
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
            Warrior attacker;
            Warrior defender;
            do
            {
                if(herd.warriors.Count > 0 && fleet.warriors.Count > 0)
                {
                    DisplayGameStats();
                    Console.WriteLine($"\n{herd.name}, attack!"); // Dinosaurs attack first

                    Console.WriteLine($"\nChoose which dinosaur will attack:");
                    attacker = herd.ChooseAttacker(herd); // Displays remaining dinosaurs able to attack
                    Console.WriteLine($"\nChoose who {attacker.name} will attack:");
                    defender = herd.ChooseOpponent(fleet); // Displays remaining robots able to be attacked
                    attacker.Attack(defender); // Runs specific attack to each warrior type
                    fleet.CheckForDead(); // check if anyone has no health left
                }

                if(herd.warriors.Count > 0 && fleet.warriors.Count > 0) // If robots still alive
                {
                    DisplayGameStats();
                    Console.WriteLine($"\n{fleet.name}, attack!"); // Robots attack second

                    Console.WriteLine($"\nChoose which robot will attack:"); // Same as above
                    attacker = fleet.ChooseAttacker(fleet);
                    Console.WriteLine($"\nChoose who {attacker.name} will attack:");
                    defender = fleet.ChooseOpponent(herd);
                    attacker.Attack(defender);
                    herd.CheckForDead();
                }
            }
            // loop while any team has members left in list
            while (herd.warriors.Count > 0 && fleet.warriors.Count > 0);
            EndGame();
        }

        public void DisplayGameStats()
        {
            Console.Clear();
            Console.WriteLine($"Current stats:\n{herd.name}:");
            foreach(Warrior warrior in herd.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
            Console.WriteLine($"\n{fleet.name}:");
            foreach (Warrior warrior in fleet.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
        }

        public void DisplayFinalStats()
        {
            Console.WriteLine($"{herd.name}:");
            foreach (Warrior warrior in herd.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
            Console.WriteLine($"\n{fleet.name}:");
            foreach (Warrior warrior in fleet.warriors)
            {
                Console.WriteLine($"  {warrior.name}: health({warrior.health}), energy({warrior.energy})");
            }
            if(herd.warriors.Count > 0)
            {
                Console.WriteLine($"No {fleet.name} survived.\n\n{herd.name} win!");
            }
            else
            {
                Console.WriteLine($"No {herd.name} survived.\n\n{fleet.name} win!");
            }
        }

        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine("The battle is over!\n\nFinal Stats:\n");
            DisplayFinalStats();
            Console.ReadLine();
        }
    }
}
