using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class Warenkorb
    {
        public Bestellung eineBestellung { get; set; }
        public int anzArtikel = 0;

        public Warenkorb()
        {

        }
        public void zurKasse()
        {
            eineBestellung = new Bestellung();
        }

        public int ArtikelHinzufuegen(string Artikel, int Menge) 
        {
            return anzArtikel + Menge;
        }
    }
}
