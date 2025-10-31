using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_lode2v2
{
    internal class Lod
    {
        public int Delka;
        public List<(int, int)> Pozice;
        public HashSet<(int, int)> Zasahy = new();

        public Lod(int delka,  List<(int, int)> pozice)
        {
            Delka = delka;
            Pozice = pozice;
        }

        public bool Zasah(int x, int y)
        {
            foreach (var item in Pozice)
            {
                if (item == (x,y))
                {
                    Zasahy.Add(item);
                    return true;
                }
            }
            return false;
        }

        public bool JePotopena()
        {
            if (Zasahy.Count == Delka)
            {
                return true;
            }
            return false;
        }
    }
}
