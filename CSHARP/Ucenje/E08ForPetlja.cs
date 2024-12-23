using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08ForPetlja
    {





        public static void Izvedi()
        {
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("*************************");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ispisujem {0}. broj.", i+1);
            }
            int suma = 0;
            for (int i = 1; i <=100; i++)
            {
                suma += i;
               // Console.WriteLine("{0} + {1} = {2}",suma-i,i,suma);



            }

            Console.WriteLine(suma); 

            for(int i =10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }


            int odKuda = 2, doKuda = 20, uvecanje = 3;


            for(int i = odKuda; i <= doKuda; i += uvecanje)
            {
                Console.WriteLine(i);




            }

            int[] niz = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(niz[3]);


            Console.WriteLine("********************");

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }


            int redaka = 8;
            int stupaca = 6;



            for (int i =0; i < redaka; i++)
            {
                for(int j=0; j < stupaca; j++)
                {
                    Console.Write("{0,4}" , (i+1) * (j+1) );
                }
                Console.WriteLine();




            }
             





        }

    }
}
