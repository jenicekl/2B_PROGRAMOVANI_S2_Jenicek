using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_lode2v2
{
    internal class Pole
    {
        private const int Velikost = 10;
        private char[,] Mriz;
        private List<Lod> Lode = new List<Lod>();

        public Pole()
        {
            Mriz = new char[Velikost, Velikost];
            for (int i = 0; i < Velikost; i++)
            {
                for (int j = 0; j < Velikost; j++)
                {
                    Mriz[i, j] = 
                    Mriz[i, j] = 'V';
                }
            }
        }

        public void cau()
        {
            for (int i = 0; i < Velikost; i++)
            {
                for (int j = 0; j < Velikost; j++)
                {
                    Console.Write(Mriz[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void Vypis()
        {
            Console.Write("  ");
            for (int j = 1; j <= Velikost; j++)
                Console.Write(j + " ");
            Console.WriteLine();

            for (int i = 0; i < Velikost; i++)
            {
                Console.Write((char)('A' + i) + " ");
                for (int j = 0; j < Velikost; j++)
                {
                    char c = Mriz[i, j];

                    switch (c)
                    {
                        case 'V':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 'L':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                        case 'X':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case 'O':
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }
                    Console.Write(c + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
                
            }
        }
        
    }
}