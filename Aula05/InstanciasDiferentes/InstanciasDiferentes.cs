using System;

namespace Aula05
{
    class InstanciasDiferentes
    {
        const int seed = 22;
        const int maxValue = 100;
        const int numNumbers = 4;

        static void Main(string[] args)
        {
            Random r1 = new Random(seed);
            Random r2 = new Random(seed);

            // Mostrar números aleatórios com o 1o gerador
            for (int i = 0; i < numNumbers; i++)
                Console.WriteLine(r1.Next(maxValue));

            Console.WriteLine();

            // Mostrar numeros aleatorios com o 2o gerador
            for (int i = 0; i < numNumbers; i++)
                Console.WriteLine(r2.Next(maxValue));
        }
    }
}
