using System;

namespace Aula03
{
    [Flags]
    public enum WoWRoles
    {
        Tank   = 1 << 0, // 1
        Healer = 1 << 1, // 2
        Damage = 1 << 2  // 4
    }
}
