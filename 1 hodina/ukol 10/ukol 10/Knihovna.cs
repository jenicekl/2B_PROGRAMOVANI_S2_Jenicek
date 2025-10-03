using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_10
{
    internal class Knihovna
    {
        public List<Kniha> Knihy { get; set; }
        public string NazevKnihovny { get; set; }

        public Knihovna(string nazevKnihovny)
        {
            NazevKnihovny = nazevKnihovny;
            Knihy = new List<Kniha>();
        }

        public void PridejKnihu(Kniha kniha)
        {
            Knihy.Add(kniha);
            Console.WriteLine("Kniha byla pridana");
        }



        public void OdeberKnihu(string nazev)
        {
            Kniha kniha = Knihy.FirstOrDefault(k => k.Nazev.Equals(nazev, StringComparison.OrdinalIgnoreCase));
            if (kniha != null)
            {
                Knihy.Remove(kniha);
                Console.WriteLine("kniha odebrana");
            }
            else
            {
                Console.WriteLine("nebylo nalezeno");
            }
        }

        public void VypisVsechnyKnihy()
        {
            if (Knihy.Count == 0)
            {
                Console.WriteLine("nejsou knihy");
            }
            else
            {
                Console.WriteLine("Knihy: ");
                foreach (var item in Knihy)
                {
                    item.VypisInformaci();
                }
            }
        }

        public void NajdiKnihuPodleNazvu(string nazev)
        {
            if (nazev == null || Knihy.Count == 0 )
            {
                Console.WriteLine("Nejde");
            }
            else
            {
                foreach (var item in Knihy)
                {
                    if (nazev == item.Nazev)
                    {
                        item.VypisInformaci();
                    }
                }
            }
        }

        public void VypisKnihyOdAutora(string autor)
        {
            if (autor == null || Knihy.Count == 0)
            {
                Console.WriteLine("Nejde");
            }
            else
            {
                foreach (var item in Knihy)
                {
                    if (autor == item.Autor)
                    {
                        item.VypisInformaci();
                    }
                }
            }
        }

    }
}
