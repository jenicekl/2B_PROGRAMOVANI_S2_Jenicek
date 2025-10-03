using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_10
{
    internal class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokVydani { get; set; }
        public int PocetStran { get; set; }

        public Kniha(string nazev, string autor, int rokVydani, int pocetStran)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
            PocetStran = pocetStran;
        }


        public void VypisInformaci()
        {
            Console.WriteLine($"Kniha: {Nazev}, Autor: {Autor}, vydana: {RokVydani} s poctem stran {PocetStran}");
        }
    }
}
