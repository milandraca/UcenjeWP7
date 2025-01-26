using System;
using System.Text;

namespace Ucenje
{
    class GeneratorLozinki
    {
        public static void Izvedi()
        {
            Console.WriteLine("Ovo je generator lozinki");

            Console.Write("Unesite zeljenu duzinu lozinki: ");
            int duzina;

            while (!int.TryParse(Console.ReadLine(), out duzina) || duzina <= 7)
            {
                Console.WriteLine("Molimo unesite validan broj za duzinu lozinke (veci od 7).");

                
            }
            bool velikaSlova = UnesiDaNe("Da li zelite velika slova? (da/ne): ");
            bool malaSlova = UnesiDaNe("Da li zelite mala slova? (da/ne): ");
            bool brojevi = UnesiDaNe("Da li zelite koristiti brojeve? (da/ne): ");
            bool interpukcijskiZnakovi = UnesiDaNe("Da li zelite koristiti interpukcijske znakove? (da/ne): ");
            bool pocinjeBrojem = UnesiDaNe("Da li lozinka pocinje sa brojem? (da/ne): ");
            bool pocinjeInterpukcijskimZnakom = UnesiDaNe("Da li lozinka pocinje sa interpukcijskim znakom? (da/ne): ");
            bool zavrsavaBrojem = UnesiDaNe("Da li lozinka zavrsava sa brojem? (da/ne): ");
            bool zavrsavaInterpukcijskimZnakom = UnesiDaNe("Da li lozinka zavrsava sa interpukcijskim znakom? (da/ne): ");
            bool ponavljajuciZnakovi = UnesiDaNe("Da li lozinka ima ponavljajuce znakove? (da/ne): ");

            Console.Write("Koliko lozinki zelite generirati? ");
            int brojLozinki;

            while (!int.TryParse(Console.ReadLine(), out brojLozinki) || brojLozinki <= 0)
            {
                Console.WriteLine("Molimo unesite validan broj za broj lozinki (veci od 0).");
            }

            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzina, velikaSlova, malaSlova, brojevi, interpukcijskiZnakovi, pocinjeBrojem, pocinjeInterpukcijskimZnakom, zavrsavaBrojem, zavrsavaInterpukcijskimZnakom, ponavljajuciZnakovi);
                Console.WriteLine("Lozinka" + (i + 1) + ": " + lozinka);
            }
        }

        public static bool UnesiDaNe(string pitanje)
        {
            string odgovor;
            do
            {
                Console.Write(pitanje);
                odgovor = Console.ReadLine()?.ToLower();
                if (odgovor != "da" && odgovor != "ne")
                {
                    Console.WriteLine("Molimo unesite 'da' ili 'ne'.");
                }
            } while (odgovor != "da" && odgovor != "ne");

            return odgovor == "da";
        }

        public static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi,
            bool interpukcijskiZnakovi, bool pocinjeBrojem, bool pocinjeInterpukcijskimZnakom, bool zavrsavaBrojem, bool zavrsavaInterpukcijskimZnakom, bool ponavljajuciZnakovi)
        {
            string velika = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string mala = "abcdefghijklmnopqrstuvwxyz";
            string broj = "0123456789";
            string znakovi = "!@#$%^&*()_+";

            string dostupniZnakovi = "";

            if (velikaSlova)
            {
                dostupniZnakovi += velika;
            }
            if (malaSlova)
            {
                dostupniZnakovi += mala;
            }
            if (brojevi)
            {
                dostupniZnakovi += broj;
            }
            if (interpukcijskiZnakovi)
            {
                dostupniZnakovi += znakovi;
            }

            if (string.IsNullOrEmpty(dostupniZnakovi))
            {
                Console.WriteLine("Morate kljuciti makar jednu kategoriju");
                return "";
            }

            long vrijeme = DateTime.Now.Ticks;

            string lozinka = "";

            for (int i = 0; i < duzina; i++)
            {
                int k = (int)((vrijeme + i) % dostupniZnakovi.Length);
                lozinka += dostupniZnakovi[k];
            }

            if (pocinjeBrojem && !char.IsDigit(lozinka[0]))
            {
                lozinka = broj[0] + lozinka.Substring(1);
            }

            if (pocinjeInterpukcijskimZnakom && !znakovi.Contains(lozinka[0].ToString()))
            {
                lozinka = znakovi[0] + lozinka.Substring(1);
            }

            if (zavrsavaBrojem && !char.IsDigit(lozinka[lozinka.Length - 1]))
            {
                lozinka = lozinka.Substring(0, lozinka.Length - 1) + broj[0];
            }

            if (zavrsavaInterpukcijskimZnakom && !znakovi.Contains(lozinka[lozinka.Length - 1].ToString()))
            {
                lozinka = lozinka.Substring(0, lozinka.Length - 1) + znakovi[0];
            }

            if (!ponavljajuciZnakovi)
            {
                HashSet<char> jedinstveniZnakovi = new HashSet<char>();
                StringBuilder novaLozinka = new StringBuilder();
                foreach (char znak in lozinka)
                {
                    if (!jedinstveniZnakovi.Contains(znak))
                    {
                        novaLozinka.Append(znak);
                        jedinstveniZnakovi.Add(znak);
                    }
                }
                lozinka = novaLozinka.ToString();
            }

            return lozinka;
        }
    }
}
