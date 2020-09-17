using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Verification
    {
        public static string VerifySwitchCase(string userInput, int start, int end) // Verify user input is within appropriate bounds
        {
            int userInputInteger;
            string validatedInput;

            bool isInteger = int.TryParse(userInput, out userInputInteger);
            // Input must be integer between start and end values of switch case before exiting while loop
            while (isInteger != true || userInputInteger < start || userInputInteger > end)
            {
                Console.Write("Invalid choice. Please try again: ");
                userInput = Console.ReadLine();
                isInteger = int.TryParse(userInput, out userInputInteger);
            }
            validatedInput = Convert.ToString(userInputInteger);
            return validatedInput;
        }

        public static bool WarriorHasEnergy(Warrior warrior, bool hasEnergy) // Verify warrior has energy to attack
        {
            if(warrior.energy > 0)
            {
                hasEnergy = true;
                return hasEnergy;
            }
            else
            {
                Console.WriteLine("This warrior doesn't have any energy to attack. Choose another warrior!");
                return hasEnergy;
            }
        }

        public static void CheckForDead(Army army) // Checks whether any warriors have died during battle
        {
            foreach (Warrior warrior in army.warriors.ToList())
            {
                if (warrior.health <= 0)
                {
                    Console.WriteLine($"\n{warrior.name} has been killed!");
                    army.warriors.Remove(warrior);
                    Console.WriteLine("Press enter to continue the game");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
