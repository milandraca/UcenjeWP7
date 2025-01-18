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

            // Na osnovu dosadađnjeg znanja:
            // Ispišite 10 puta jedno ispod drugog Osijek
            // OVO NIJE DOBRA PRAKSA (Best practice)
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

            Console.WriteLine("**********************");

            for (int i = 0; i < 10; i++)// PAZITI DA OVDJE NE DOĐE Točka zarez ; // i=i+1, i+=1
            {
                Console.WriteLine("Osijek");
            }


            // kao i kod if ne moraju biti {} asli se onda petlja odnosi samo na prvu sljedeću liniju

            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Ispisujem {0}. broj.", i+1);
            }

            // zbroj prvih 100 brojeva
            int suma = 0;
            for(int i = 1; i <= 10; i++)
            {
                suma += i;
                // ako želimo praziti proces, ispisujemo unutar petlja, prije }
                //Console.WriteLine("{0} + {1} = {2}",suma-i,i,suma);
            }

            // ako želimo samo rezultat, ispisujemonakon petlja, nakon }
            Console.WriteLine(suma);


            // petlja može ići i "unazad"
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("************************");

            // petlja ne mora ići za korak 1
            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("************************");

            int odKuda = 2, doKuda = 20, uvecanje = 3; // simulacija da je unio korisnik

            // ono čemu težimo u kodu jest kod bez konstanti
            for(int i = odKuda; i <= doKuda; i += uvecanje)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************");


            int[] niz = { 2, 3, 4, 5, 3, 2, 2 }; // dužina je 7

            // Ispišite broj 5
            Console.WriteLine(niz[3]);

            Console.WriteLine("************************");
            // u novim linijama ispiši sve elemente niza
            
            for(int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]); // ovo je slovo i, ne broj 1
            }

            int redaka = 8;
            int stupaca = 6;


            // for petlja se može gnijezditi
            for(int i = 0; i < redaka; i++)
            {


                for(int j = 0; j < stupaca; j++)
                {
                    Console.Write("{0,4}", (i+1) * (j+1));
                }

                Console.WriteLine();

            }


            // petlju se može preskočiti - nastaviti

            for(int i = 0;i < 10; i++)
            {
                if (i == 4) // preskoči 5. mjesto
                {
                    continue; // vraća na početak petlja
                }

                Console.WriteLine("Rezerviraj {0}. mjesto", i+1);

            }


            // petlja se može "nasilno" prekinuti
            for(int i=0; i < 10; i++) //prirodni kraj je i=10
            {
                if(i== 5)
                {
                    break; // nasilno prekidam
                }
                Console.WriteLine(i);
            }



            // korisnost break-a
            // prim broj, prime number, prosti broj
            // 2 3 5 7 11 13 17
            // zašto 4 nije prim broj? Cjelobrojno je djeljiv s 2

            int brojZaProvjeru = 157;
            int brojacIteracija = 1;
            bool prim = true; // moja hipoteza je da taj broj je PRIM broj
            for(int i = 2;i<brojZaProvjeru/2; i++)
            {
                Console.WriteLine("{0}%{1}=={2} ({3})", brojZaProvjeru, i, brojZaProvjeru%i, brojacIteracija++);
                if(brojZaProvjeru%i== 0)
                {
                    // TO NIJE PRIM BROJ
                    prim = false;
                    break;
                }
            }

            Console.WriteLine("{0} {1} prim broj", brojZaProvjeru, prim ? "JE" : "NIJE");


            // Za razbribrigu tijekom dugih zimskih noći https://hr.wikipedia.org/wiki/Eratostenovo_sito





            // beskonačna petlja
            for(int i = 0; i > -1; i++) // OVO NIJE BESKONAČNA PETLJA zbog brojevne kružnice
            {
                break;
            }


            for(; ; ) // ovo je sintaksa for beskonačne petlje
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0}", new Random().Next());
                Thread.Sleep(100);
                //break; // ovo osloboditi ili svaki puta ručni zaustaviti program
            }




        }





    }
}
