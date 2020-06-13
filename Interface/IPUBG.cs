using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class IPUBG : IGameTembakMenembak
    {
        public void menembak()
        {
            Console.WriteLine("Game PUBG adalah game tembak-menembak");
            Console.WriteLine("Buatan oleh PUBG Corporation");
        }
    }
}
