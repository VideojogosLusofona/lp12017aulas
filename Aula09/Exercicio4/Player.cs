using System;

namespace Aula09
{
    public class Player : Character
    {
        public override char Move()
        {
            Console.WriteLine("Use WSAD to chose a direction: ");
            char cDir = Convert.ToChar(Console.ReadLine());
            switch (cDir)
            {
                case 'W':
                    return 'N';
                case 'A':
                    return 'W';
                case 'S':
                    return 'S';
                case 'D':
                    return 'E';
                default:
                    // If player presses invalid key we just return North
                    return 'N';
            }
        }

        public Player(string name) : base(name) { }
    }
}
