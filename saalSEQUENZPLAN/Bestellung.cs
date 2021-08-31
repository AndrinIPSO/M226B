using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saalSEQUENZPLAN
{
    public class Bestellung
    {
        private saalplan _saalplan = new saalplan();

        public Bestellung()
        {

        }
        
        public Bestellung(saalplan saaplana)
        {
            _saalplan = saaplana;
        }
    }
}
