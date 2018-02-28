using System;

namespace Aula01
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i}: '{args[i]}'");
            }
        }
    }
}
