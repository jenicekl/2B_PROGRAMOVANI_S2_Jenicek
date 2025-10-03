using System.Net;

namespace ukol_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna("Městská knihovna");

            knihovna.PridejKnihu(new Kniha("1984", "George Orwell", 1949, 328));
            knihovna.PridejKnihu(new Kniha("Malý princ", "Antoine de Saint-Exupéry", 1943, 96));
            knihovna.PridejKnihu(new Kniha("Kytice", "Karel Jaromír Erben", 1853, 220));
            knihovna.PridejKnihu(new Kniha("Harry Potter a Kámen mudrců", "J.K. Rowling", 1997, 309));
            knihovna.PridejKnihu(new Kniha("Pán prstenů: Společenstvo prstenu", "J.R.R. Tolkien", 1954, 423));
            knihovna.PridejKnihu(new Kniha("Hobit", "J.R.R. Tolkien", 1937, 310));
            knihovna.PridejKnihu(new Kniha("Babička", "Božena Němcová", 1855, 356));
            knihovna.PridejKnihu(new Kniha("Krysař", "Viktor Dyk", 1915, 144));
            knihovna.PridejKnihu(new Kniha("Romeo a Julie", "William Shakespeare", 1597, 220));
            knihovna.PridejKnihu(new Kniha("Faust", "Johann Wolfgang Goethe", 1808, 450));
            Console.Clear();

            bool bez = true;
            
            while (bez)
            {
                Console.WriteLine("Knihovna");
                Console.WriteLine("1. Přidej knihu");
                Console.WriteLine("2. Odeber Knihu podle nazvu");
                Console.WriteLine("3. Vyhledej knihu podle nazvu");
                Console.WriteLine("4. Vyhledej knihy od autora");
                Console.WriteLine("5. Zobraz vsechny knihy");
                Console.WriteLine("0. ukonict");
                Console.WriteLine();

                Console.Write("Vyber: ");
                string vyber = Console.ReadLine();
                switch (vyber)
                {
                    case "1":
                        Console.WriteLine("Zadej nazev knihy: ");
                        string vyber1 = Console.ReadLine();
                        Console.WriteLine("Zadej nazev Autora: ");
                        string vyber2 = Console.ReadLine();
                        Console.WriteLine("Zadej rok vydani: ");
                        int vyber3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Zadej pocet stran: ");
                        int vyber4 = int.Parse(Console.ReadLine());
                        knihovna.PridejKnihu(new Kniha(vyber1, vyber2, vyber3, vyber4));
                        break;
                    case "2":
                        Console.WriteLine("Zadej nazev knihy: ");
                        string nazev = Console.ReadLine();
                        knihovna.OdeberKnihu(nazev);
                        break;
                    case "3":
                        Console.WriteLine("Zadej nazev knihy: ");
                        string nazev1 = Console.ReadLine();
                        knihovna.NajdiKnihuPodleNazvu(nazev1);
                        break;
                    case "4":
                        Console.WriteLine("Zadej jmeno Autora: ");
                        string jmeno = Console.ReadLine();
                        knihovna.VypisKnihyOdAutora(jmeno);
                        break;
                    case "5":
                        knihovna.VypisVsechnyKnihy();
                        break;
                    case "0":
                        bez = false;
                        break;
                    default:
                        Console.WriteLine("Zla volba");
                        break;
                }
            }

        }
    }
}
