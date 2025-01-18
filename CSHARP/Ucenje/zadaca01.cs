using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class zadaca01
    {

        public static void pravokutnik()
        {

            Console.Write("Unesi visinu: ");
            float visina = float.Parse(Console.ReadLine());

            Console.Write("Unesi širinu: ");
            float sirina = float.Parse(Console.ReadLine());


            float povrsina = visina * sirina;

            Console.WriteLine("Pobršina pravokutnika je: {0}",povrsina );





        }
    }
}
