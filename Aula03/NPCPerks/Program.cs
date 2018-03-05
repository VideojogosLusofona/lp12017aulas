using System;

namespace Aula03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Constantes
            const NPCPerks niceCombo = NPCPerks.Combat | NPCPerks.Luck;

            // Variaveis
            NPCPerks[] npcs;
            string tmp;
            int numNPCs;

            // Pedir numero de PCs ao utilizador
            Console.Write("Indica o numero de NPCs: ");
            tmp = Console.ReadLine();
            numNPCs = Convert.ToInt32(tmp);

            // Criar array de NPCs
            npcs = new NPCPerks[numNPCs];
            npcs.Initialize();

            // Pedir ao utilizador para indicar as caracteristicas de cada NPC
            for (int i = 0; i < numNPCs; i++)
            {
                // Inicializar NPC atual a zero (sem nada ainda)
                npcs[i] = 0;

                Console.WriteLine("NPC " + (i + 1) + "\n------------");
                // Este NPC tem característica Stealth?
                do
                {
                    Console.Write("Stealth (s/n)? ");
                    tmp = Console.ReadLine();
                } while ((tmp != "s") && (tmp != "n"));

                if (tmp == "s")
                {
                    npcs[i] |= NPCPerks.Stealth;
                }

                // Este NPC tem característica Combat?
                do
                {
                    Console.Write("Combat (s/n)? ");
                    tmp = Console.ReadLine();
                } while ((tmp != "s") && (tmp != "n"));

                if (tmp == "s")
                {
                    npcs[i] |= NPCPerks.Combat;
                }

                // Este NPC tem característica Lockpick?
                do
                {
                    Console.Write("Lockpick (s/n)? ");
                    tmp = Console.ReadLine();
                } while ((tmp != "s") && (tmp != "n"));

                if (tmp == "s")
                {
                    npcs[i] |= NPCPerks.Lockpick;
                }

                // Este NPC tem característica Luck?
                do
                {
                    Console.Write("Luck(s/n)? ");
                    tmp = Console.ReadLine();
                } while ((tmp != "s") && (tmp != "n"));

                if (tmp == "s")
                {
                    npcs[i] |= NPCPerks.Luck;
                }
            }

            // Mostrar caracteristicas de cada NPC
            Console.WriteLine("\nCaracteristicas de cada NPC\n---------------");
            for (int i = 0; i < numNPCs; i++)
            {
                Console.Write($"NPC {i + 1}: {npcs[i]}");
                if ((npcs[i] & niceCombo) == niceCombo)
                {
                    Console.Write("\t<<< You shall win all fights! >>>");
                }
                Console.WriteLine();
            }
        }
    }
}