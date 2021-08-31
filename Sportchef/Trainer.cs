using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportchef
{
    public class Trainer
    {
        public string club { get; set; }
        public List<Spieler> spieler = new List<Spieler>();


        public void trainieren()
        {
            int ii = 0;
            foreach (Spieler spieler in spieler)
            {
                ii++;
                Console.Write($"Spieler {ii} ");
                spieler.tranieren();
            }
        }
    }
}
