using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KochsequenzDiagramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Herd Herdi = new Herd();
            Koch Sepp = new Koch(Herdi);


            Console.Read();
        }
    }
}
