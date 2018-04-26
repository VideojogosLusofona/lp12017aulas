using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters {
    public abstract class Character {
        public string Name { get; }

        public abstract char Move();

        public Character(string name) {
            Name = name;
        }
    }
}
