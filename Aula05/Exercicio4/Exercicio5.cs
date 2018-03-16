using System;

namespace Aula05
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int nDados, soma = 0;
            Random r = new Random();

            // Pedir número de dados ao utilizador
            Console.Write("Quantos dados queres lançar? ");
            nDados = Convert.ToInt32(Console.ReadLine());

            // Lançar dados o número de vezes indicado pelo utilizador
            for (int i = 0; i < nDados; i++)
            {
                // Obter valor do dado entre 1 e 6
                int valorDado = r.Next(1, 7);

                // Somar valor do dado ao total até agora
                soma += valorDado;

                // Mostrar valor do dado (não era pedido, mas ajuda a perceber)
                Console.WriteLine($"- Valor dado {i + 1}: {valorDado}");
            }

            // Mostrar soma de todos os lançamentos de dados
            Console.WriteLine("=> Total: " + soma);
        }
    }
}
