using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Varijable
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E02");


            //tipovi podataka

            int cijeliBroj = 1;

            bool logickaVrijednost = true;

            float decimalniBroj = 4.5f;

            double velikiDecimalniBroj = 3.14;

            decimal decimalniBroj2 = 3.4M;

            char znak = '@';

            string nizZnakova = "abcdefg";

            Console.WriteLine("Znak je broj {0}", (int)znak);

            cijeliBroj = int.MaxValue;
            Console.WriteLine(cijeliBroj);

            Console.WriteLine(cijeliBroj);
            Console.WriteLine(cijeliBroj+1);



            


        }






    }
}
