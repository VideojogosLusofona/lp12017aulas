using System;

namespace Aula04
{
    public class ProgramWithMethods
    {
        // Metodo que faz a leitura de um dado perk
        static NPCPerks ReadPerk(NPCPerks perk)
        {
            // Variaveis
            string tmp;
            NPCPerks readPerk = 0;

            // Pedir ao user para confirmar perk
            do
            {
                Console.Write(perk + " (s/n)? ");
                tmp = Console.ReadLine();
            } while ((tmp != "s") && (tmp != "n"));

            // User confirmou perk?
            if (tmp == "s")
            {
                // Confirmar que sim
                readPerk = perk;
            }

            // Retornar possivel perk lido
            return readPerk;
        }

        // Metodo Main
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
                npcs[i] |= ReadPerk(NPCPerks.Stealth);

                // Este NPC tem característica Combat?
                npcs[i] |= ReadPerk(NPCPerks.Combat);

                // Este NPC tem característica Lockpick?
                npcs[i] |= ReadPerk(NPCPerks.Lockpick);

                // Este NPC tem característica Luck?
                npcs[i] |= ReadPerk(NPCPerks.Luck);

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