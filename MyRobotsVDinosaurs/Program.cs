using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield.WelcomeToGame();
            Battlefield battlefield = new Battlefield();
            battlefield.DoBattle();

            // Regenerate energy each turn
            // chance for attack to miss/chance for critical hit
            // types of warriors (attacker (high attack, low defense), defender (low attack, high defense), balanced (balanced attack/defense))
            // robot choose name of weapon, but power of weapon depends on type of warrior it is
            // better color commentary (Welcome screen, more specific details about attacks
            // choose who goes first
        }
    }
}
