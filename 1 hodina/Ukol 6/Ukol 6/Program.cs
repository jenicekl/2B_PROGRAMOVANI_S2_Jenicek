namespace Ukol_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kruh kruh = new Kruh(5);
            Console.WriteLine("Obvod:" + kruh.VypocitejObvod());
            Console.WriteLine("Obsah:" + kruh.VypoctejObsah());
        }
    }
}
