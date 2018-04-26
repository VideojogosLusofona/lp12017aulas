using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface {
    public class Player : Character, IKeyControllable {

        public char ReadControlKey() {
            Console.WriteLine("Chose a direction 'N, S, W, E':");
            char cDir = Convert.ToChar(Console.ReadLine());
            return cDir;
        }

        public override char Move() {
            switch (ReadControlKey()) {
                case 'W':
                    return 'N';
                case 'A':
                    return 'E';
                case 'S':
                    return 'S';
                case 'D':
                    return 'D';
                default:
                    return 'N';
            }
        }

        public Player(string name) : base(name) { }
    }
}
