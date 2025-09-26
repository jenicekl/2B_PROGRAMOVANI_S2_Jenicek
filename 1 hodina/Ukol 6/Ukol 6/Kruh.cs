using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_6
{
    internal class Kruh
    {
        public double Polomer;

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }
        public double VypocitejObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double VypoctejObsah()
        {
            return Math.PI * Polomer * Polomer;
        }

    }
}
