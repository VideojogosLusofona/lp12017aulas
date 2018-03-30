using System;

namespace Aula06_Classes {
    internal class Ball {
        private Color color;
        private double size;
        private int timesThrown = 0;

        public Ball(Color color, double size) {
            this.color = color;
            this.size = size;
        }

        public void Pop() {
            this.size = 0;
        }

        public bool Throw() {
            bool val = false;

            if (this.size > 0) {
                timesThrown++;
                val = true;
            }

            return val;
        }

        public int GetTimesThrown() {
            return this.timesThrown;
        }
    }
}
