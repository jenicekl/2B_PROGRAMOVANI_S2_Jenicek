using System.Security.Authentication.ExtendedProtection;

namespace ukol_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Pole = VytvorPole(10);
            VypisPole(Pole);
            Console.WriteLine();

            Console.WriteLine("Min: " + NajdiMin(Pole));
            Console.WriteLine("Max: " + NajdiMax(Pole));
            Console.WriteLine("Prumer: " + Prumer(Pole));
        }

        static int[] VytvorPole (int velikost)
        {
            int[] pole = new int[velikost];
            Random rand = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rand.Next();
            }
            return pole;
        }

        static void VypisPole(int[] pole)
        {
            Console.Write("Pole: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + ", ");
            }
        }

        static int NajdiMin(int[] pole)
        {
            int Min = int.MaxValue;
            for (int i = 0; i < pole.Length; i++)
            {
                if (Min > pole[i])
                {
                    Min = pole[i];
                }
            }
            return Min;
        }

        static int NajdiMax(int[] pole)
        {
            int Max = int.MinValue;
            for (int i = 0; i < pole.Length; i++)
            {
                if (Max < pole[i])
                {
                    Max = pole[i];
                }
            }
            return Max;
        }

        static double Prumer(int[] pole)
        {
            int soucet = 0;
            double prumer = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            prumer = soucet / pole.Length;
            return prumer;
        }
    }
}
