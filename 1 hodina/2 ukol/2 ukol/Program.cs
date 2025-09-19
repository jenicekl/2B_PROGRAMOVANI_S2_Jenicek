namespace _2_ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] pole = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pole[i,j] = rand.Next(1, 51);
                }
            }

            Console.WriteLine("Pole: ");
            for (int i = 0;i < 5; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.Write(pole[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(min > pole[i, j])
                    {
                        min = pole[i,j];
                    }
                    if(max < pole[i, j])
                    {
                        max = pole[i,j];
                    }
                }
            }
            
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");


            int soucet = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soucet += pole[i, j];
                }
            }
            Console.WriteLine($"Soucet vsech cisel je: {soucet}");


            Console.WriteLine("Hlavni diagonal: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pole[i,i] + " ");
            }
        }
    }
}
