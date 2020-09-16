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
            herd.dinosaurs[0].Attack(fleet.robots[0]);
            fleet.robots[0].Attack(herd.dinosaurs[0]);
        }
    }
}
