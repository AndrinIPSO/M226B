using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KochsequenzDiagramm
{
    public class Herd
    {
        public Herd()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--> Herd Instanziiert");
        }
        public void Einschalten()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>> Herd Eingeschaltet");
        }

        public void Ausschalten()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> Herd Ausgeschaltet");
        }

    }
}
