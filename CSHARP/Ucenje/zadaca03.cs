using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class zadaca03
    {
        public static void Pozitiv()
        {
            int broj;


            Console.WriteLine("Unesi jedan broj: ");

            broj = int.Parse(Console.ReadLine());
            if (broj > 0)


            {
                Console.WriteLine("Broj {0} je pozitivan  ", broj);

            }
            else if (broj < 0) { Console.WriteLine("Broj {0} je negativan", broj); }

            else { Console.WriteLine("Broj je 0"); }


        }
    }
}
