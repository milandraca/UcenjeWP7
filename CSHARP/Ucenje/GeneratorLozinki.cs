using System.Text;

namespace Ucenje
{
    class GeneratorLozinki
    {
        public static void Izvedi()
        {
            Console.WriteLine("Ovo je generator lozinki");

            Console.Write("Unesite zeljenu duzinu lozinki: ");
            int duzina = int.Parse(Console.ReadLine());

            Console.WriteLine("+++++ Enter = NE +++++");

            Console.WriteLine("Da li zelite velika slova? (da/ne)");
            bool velikaSlova = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li zelite mala slova? da/ne)");
            bool malaSlova = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li zelite koristiti brojeve? (da/ne)");
            bool brojevi = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li zelite koristiti interpukcijske znakove? (da/ne)");
            bool interpukcijskiZnakovi = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li lozinka pocinje sa brojem? (da/ne)");
            bool pocinjeBrojem = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li lozinka pocinje sa interpukcijskim znakom? (da/ne)");
            bool pocinjeInterpukcijskimZnakom = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li lozinka zavrsava sa brojem? (da/ne)");
            bool zavrsavaBrojem = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li lozinka zavrsava sa interpukcijskim znakom? (da/ne)");
            bool zavrsavaInterpukcijskimZnakom = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Da li lozinka ima ponavljajuce znakove? (da/ne)");
            bool ponavljajuciZnakovi = Console.ReadLine()?.ToLower() == "da";

            Console.WriteLine("Koliko lozinki zelite generirati");
            int brojLozinki = int.Parse(Console.ReadLine());

            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzina, velikaSlova, malaSlova, brojevi, interpukcijskiZnakovi, pocinjeBrojem, pocinjeInterpukcijskimZnakom, zavrsavaBrojem, zavrsavaInterpukcijskimZnakom, ponavljajuciZnakovi);
                Console.WriteLine("Lozinka" + (i + 1) + ": " + lozinka);
            }
        }

        public static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi,
            bool interpukcijskiZnakovi, bool pocinjeBrojem, bool pocinjeInterpukcijskimZnakom, bool zavrsavaBrojem, bool zavrsavaInterpukcijskimZnakom, bool ponavljajuciZnakovi)
        {
            string velika = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string mala = "abcdefghijklmnopqrstuvwxyz";
            string broj = "0123456789";
            string znakovi = "!@#$%^&*()_+";

            string dostupniZnakovi = "";

            if (velikaSlova) dostupniZnakovi += velika;
            if (malaSlova) dostupniZnakovi += mala;
            if (brojevi) dostupniZnakovi += broj;
            if (interpukcijskiZnakovi) dostupniZnakovi += znakovi;

            
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
