using System;

namespace Aula03
{
    class BreakContinue
    {
        static void Main(string[] args)
        {
            const int maxTurns = 20;
            int turn = 0;
            while (true)
            {
                turn++;

                if (turn >= maxTurns)
                {
                    break;
                }

                if (turn % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine($"Turn number {turn}");
            }

            Console.WriteLine($"Last turn was {turn}");
        }
    }
}
