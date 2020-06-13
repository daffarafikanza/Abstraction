using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class CSGO : IGameTembakMenembak
    {
        public void menembak()
        {
            Console.WriteLine("Game CSGO adalah game tembak-menembak");
            Console.WriteLine("Buatan oleh Valve Corporation");
        }
    }
}
