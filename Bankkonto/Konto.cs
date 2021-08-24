using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class Konto : IReadWrite
    {
        private double kontostand;

        public Konto()
        {
            kontostand = 5000.0;
        }

        public double Kontostand(double amount)
        {
            kontostand += amount;
            return kontostand;
        }
    }
}
