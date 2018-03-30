using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Classes {
    class Program {
        static void Main(string[] args) {
            byte R, G, B, A;
            double size;
            Color color1 = null;
            Ball ball1 = null;

            //Os argumentos são passados pela linha de comandos
            //arg 0 = Red
            //arg 1 = Green
            //arg 2 = Blue
            //arg 3 = Alpha
            //arg 4 = Size

            R = Convert.ToByte(args[0]);
            G = Convert.ToByte(args[1]);
            B = Convert.ToByte(args[2]);
            A = Convert.ToByte(args[3]);

            color1 = new Color(R, G, B, A);

            size = Convert.ToDouble(args[4]);

            ball1 = new Ball(color1, size);

            for (int i = 0; i < 10; i++) {
                if (i == 6) {
                    ball1.Pop();
                }

                if (ball1.Throw()) {
                    Console.WriteLine("Ball thrown");
                }
            }

            Console.WriteLine("\nThe ball was thrown " + ball1.GetTimesThrown()
                + " times");

            Console.WriteLine("\n--------- Color Methods ---------\n");

            Console.WriteLine("Red: " + color1.GetR());
            Console.WriteLine("Green: " + color1.GetG());
            Console.WriteLine("Blue: " + color1.GetB());
            Console.WriteLine("Alpha: " + color1.GetA());
            Console.WriteLine("Greyscale: " + color1.GetGreyscale());

        }
    }
}
