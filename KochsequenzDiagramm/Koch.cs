using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KochsequenzDiagramm
{
    public class Koch
    {
        private Herd _herd;

        public Herd herd
        {
            get { return _herd; }
            set { _herd = value; }
        }

        public Koch()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--> Koch Instanziiert");
        }
        public Koch(Herd herd)
        {
            this.herd = herd;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--> Koch mit Herd Instanziiert");
            herd.Einschalten();
            herd.Ausschalten();
        }
    }
}
