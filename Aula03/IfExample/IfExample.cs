using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class IfExample
    {
        static void Main(string[] args)
        {
            char smile = '\u263A';
            char frown = '\u2639';
            char skull = '\u2620';

            SpaceShip spaceShip = new SpaceShip();

            bool shieldsUp = spaceShip.Shield > 0;
            bool armourOk = spaceShip.Armour > 0;

            if (shieldsUp && armourOk)
            {
                Console.WriteLine($"You're doing great {smile}");
            }
            else if (shieldsUp ^ armourOk)
            {
                Console.WriteLine($"You don't look so good {frown}");
            }
            else
            {
                Console.WriteLine($"You're dead {skull}");
            }
        }
    }
}
