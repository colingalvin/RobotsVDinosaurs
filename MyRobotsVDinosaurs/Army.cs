using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobotsVDinosaurs
{
    class Army
    {
        // member variables (HAS A)

        public string name;
        public List<Warrior> warriors;

        // constructor (SPAWN)

        public Army(string name)
        {
            this.name = name;
            warriors = new List<Warrior>();
        }

        // member methods (CAN DO)

        /* public virtual void ChooseAttacker(string userInput)
        {
            Console.WriteLine("Choose who will attack: ");
            userInput = Console.ReadLine();
            switch(userInput)
            {
                
            }
        } */
    }
}
