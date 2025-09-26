namespace Ukol_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> list = VytvorList();
          Vypis(list);
          list = pridatCislo(list);
            list = odebratsude(list);
            Vypis(list);
        }

        static List<int> VytvorList()
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(rand.Next(1, 101));
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

        static List<int> pridatCislo(List<int> list)
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
