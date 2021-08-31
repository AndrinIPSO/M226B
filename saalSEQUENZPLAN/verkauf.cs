using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saalSEQUENZPLAN
{
    public class verkauf
    {
        Bestellung _bestellung = new Bestellung();

        public verkauf()
        {

        }
        public verkauf(Bestellung Bestellung)
        {
            _bestellung = Bestellung;
        }
    }
}
