using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstract_Class
{
    public class CSGO : GameTembakMenembak
    {
        public override void menembak()
          {
            Console.WriteLine("Game CSGO adalah game tembak-menembak");
            Console.WriteLine("Buatan oleh Valve Corporation");
        }
    }
}