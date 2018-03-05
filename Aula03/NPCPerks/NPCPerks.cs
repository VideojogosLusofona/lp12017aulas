using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    [Flags]
    enum NPCPerks
    {
        Stealth = 1 << 0,
        Combat = 1 << 1,
        Lockpick = 1 << 2,
        Luck = 1 << 3
    }
}
