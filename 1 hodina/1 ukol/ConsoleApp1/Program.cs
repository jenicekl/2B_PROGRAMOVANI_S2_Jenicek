namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] pole = new int[10];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rand.Next(1, 101);
            }

            Console.Write("obsah pole:");
            foreach (int x in pole)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();

            int min = int.MaxValue;
            int max = 0;

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < min)
                {
                    min = pole[i];
                }
                if (pole[i] > max)
                {
                    max = pole[i];
                }
            }

            Console.WriteLine($"nejmensi hodnota: {min}");
            Console.WriteLine($"nejvetsi hodnota: {max}");

            double soucet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            double prumer = soucet / pole.Length;
            Console.WriteLine($"prumer: {prumer}");

            Array.Sort(pole);

            Console.WriteLine("serazene pole:");
            foreach (int x in pole)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();

        }
    }
}
