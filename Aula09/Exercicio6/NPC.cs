using System;

namespace Aula09
{
    public class NPC : Character
    {
        Random r = new Random();

        public override char Move()
        {
            int rDir = r.Next(0, 4);
            switch (rDir)
            {
                case 0:
                    return 'W';
                case 1:
                    return 'E';
                case 2:
                    return 'N';
                case 3:
                    return 'S';
                default:
                    // We'll never get here
                    return 'N';
            }
        }

        public NPC(string name) : base(name) { }
    }
}
