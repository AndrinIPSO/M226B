using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportchef
{
    public abstract class Spieler
    {
        public string Rufname { get; set; }

        public Spieler()
        {

        }

        public Spieler(string rufname)
        {
            Rufname = rufname;
        }

        public abstract void tranieren();
    }
}
