using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletjatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EletjatekSzimulator Jatek = new EletjatekSzimulator(10,10);;
            while (!Console.KeyAvailable)
            {
                Jatek.Run();
            }
            Console.ReadKey();
        }
    }
}
