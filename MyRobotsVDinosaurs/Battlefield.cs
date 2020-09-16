using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Battlefield
    {
        // member variables
        public Herd herd;
        public Fleet fleet;

        // constructor

        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        // member methods

        public void DoBattle()
        {
            do
            {
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                fleet.robots[0].Attack(herd.dinosaurs[0]);
                herd.dinosaurs[1].Attack(fleet.robots[1]);
                fleet.robots[1].Attack(herd.dinosaurs[1]);
                herd.dinosaurs[2].Attack(fleet.robots[2]);
                fleet.robots[2].Attack(herd.dinosaurs[2]);
            }
            while ((herd.dinosaurs[0].health > 0 || herd.dinosaurs[1].health > 0 || herd.dinosaurs[2].health > 0) && (fleet.robots[0].health > 0 || fleet.robots[1].health > 0 || fleet.robots[2].health > 0));
            EndGame();
        }

        public void EndGame()
        {
            Console.WriteLine("Battle has concluded.");
        }
    }
}
