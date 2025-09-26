namespace Ukol_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = VytvorDictionary();
            Vypis(dic);
            ZmenitZnamku(dic);
            Vypis(dic);
        }

        static Dictionary<string, int> VytvorDictionary()
        {
            return new Dictionary<string, int>()
            {
                { "Adam", 1 },
                { "Bára", 2 },
                { "Cyril", 3 },
                { "Dana", 1 },
                { "Eva", 2 }
            };
        }

        static void Vypis(Dictionary<string,  int> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        static void ZmenitZnamku(Dictionary<string, int> dic)
        {
            Console.WriteLine("Zadej jmeno");
            string jmeno = Console.ReadLine();

            if (dic.ContainsKey(jmeno))
            {
                Console.WriteLine("ZAdej znamku");
                int znamka = int.Parse(Console.ReadLine());
                dic[jmeno] = znamka;
            }
            else
            {
                Console.WriteLine("Neni");
            }
        }
    }
}
