using System;

namespace Aula06_Classes {
    internal class Color {
        private byte R;
        private byte G;
        private byte B;
        private byte A;

        public Color(byte R, byte G, byte B, byte A) {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public Color(byte R, byte G, byte B) {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = 255;
        }

        public byte GetR() {
            return this.R;
        }

        public byte GetG() {
            return this.G;
        }

        public byte GetB() {
            return this.B;
        }

        public byte GetA() {
            return this.A;
        }

        public void SetR(byte r) {
            this.R = r;
        }

        public void SetG(byte g) {
            this.G = g;
        }

        public void SetB(byte b) {
            this.B = b;
        }

        public void SetA(byte a) {
            this.A = a;
        }

        public int GetGreyscale() {
            return (this.R + this.G + this.B + this.A) / 4;
        }
    }
}
