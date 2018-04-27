using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface {
    public class NPC : Character {
        Random r = new Random();

        public override char Move() {
            int rDir = r.Next(0, 3);
            char mDir;
            switch (rDir) {
                case 0:
                    mDir = 'W';
                    return mDir;
                case 1:
                    mDir = 'E';
                    return mDir;
                case 2:
                    mDir = 'N';
                    return mDir;
                case 3:
                    mDir = 'S';
                    return mDir;
                default:
                    return 'N';
            }
        }

        public NPC(string name) : base(name) { }
    }
}
