using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class COD : IGameTembakMenembak
    {
        public void menembak()
        {
            Console.WriteLine("Game COD adalah game tembak-menembak");
            Console.WriteLine("Buatan oleh Activision");
        }
    }
}
