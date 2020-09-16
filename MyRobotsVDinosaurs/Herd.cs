using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Herd
    {
        // member variables

        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        // constructor

        public Herd() // Contains list of 3 dinosaur objects
        {
            Dinosaur dinosaur1 = new Dinosaur();
            dinosaurs.Add(dinosaur1);
            Dinosaur dinosaur2 = new Dinosaur();
            dinosaurs.Add(dinosaur2);
            Dinosaur dinosaur3 = new Dinosaur();
            dinosaurs.Add(dinosaur3);
        }

        // member methods
    }
}
