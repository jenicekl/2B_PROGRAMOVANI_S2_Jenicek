namespace Ukol_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> list = VytvorList(1, 101, 20);
          Vypis(list);
          list = pridatCislo(list, 1, 101);
            list = odebratsude(list);
            Vypis(list);
        }

        static List<int> VytvorList(int min, int max, int delka)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < delka; i++)
            {
                list.Add(rand.Next(min, max));
            }
            return list;
        }

        static void Vypis(List<int> list)
        {
            foreach(int i in list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        static List<int> pridatCislo(List<int> list, int min, int max)
        {
            Random rand = new Random();
            list.Add(rand.Next(1,101));
            return list;

        }

        static List<int> odebratsude(List<int> list)
        {
            list.RemoveAll(x => x % 2 == 0);
            return list;
        }
    }
}
