using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters {
    public class Player : Character {

        public override char Move() {
            Console.WriteLine("Chose a direction 'N, S, W, E':");
            char cDir = Convert.ToChar(Console.ReadLine());
            switch (cDir) {
                case 'W':
                    cDir = 'N';
                    return cDir;
                case 'A':
                    cDir = 'E';
                    return cDir;
                case 'S':
                    cDir = 'S';
                    return cDir;
                case 'D':
                    cDir = 'W';
                    return cDir;
                default:
                    return cDir;
            }
        }

        public Player(string name) : base(name) { }
    }
}
