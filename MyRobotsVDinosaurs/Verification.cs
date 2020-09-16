﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Verification
    {
        public static string VerifySwitchCase(string userInput, int start, int end)
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
    }
}
