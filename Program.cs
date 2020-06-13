using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.Abstract_Class;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*GameTembakMenembak gametembakmenembak;

            gametembakmenembak = new COD();
            gametembakmenembak.menembak();

            Console.WriteLine();
            gametembakmenembak = new CSGO();
            gametembakmenembak.menembak();

            Console.WriteLine();
            gametembakmenembak = new PUBG();
            gametembakmenembak.menembak();*/

            IGameTembakMenembak gametembakmenembak;

            gametembakmenembak = new ICOD();
            gametembakmenembak.menembak();

            Console.WriteLine();
            gametembakmenembak = new ICSGO();
            gametembakmenembak.menembak();

            Console.WriteLine();
            gametembakmenembak = new IPUBG();
            gametembakmenembak.menembak();

            Console.ReadKey();
        }
    }
}