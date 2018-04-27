using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] chars = new Character[2];
            chars[0] = new Player("Player");
            chars[1] = new NPC("NPC");
            foreach (Character c in chars)
            {
                char direction = c.Move();
                Console.WriteLine(c.Name + " : " + direction);
            }
        }
    }
}
