using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_7
{
    internal class Auto
    {
        public string Znacka;
        public string Model;
        public int RokVyroby;
        public int NajeteKilometry;
        public Auto(string znacka, string model, int rok, int najet) 
        {
            Znacka = znacka;
            Model = model;
            RokVyroby = rok;
            NajeteKilometry = najet;
        }


    }
}
