using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class zadaca02
    {
        public static void Zbroj()
        {

            Console.WriteLine("Unesi velicinu niza: ");   //5
            int n = int.Parse(Console.ReadLine());

            int[] niz = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Unesi vrijednost {0},", i + 1);
                niz[i] = int.Parse(Console.ReadLine());
            }

            int suma=0;


            for (int i = 0; i <= n; i++)
            {

                suma = suma + niz[i];



            }

            Console.WriteLine("Suma je: {0} ", suma);




    }   }
   
}
