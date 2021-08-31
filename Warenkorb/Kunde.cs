using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class Kunde
    {
        public Warenkorb EinWarenkorb = new Warenkorb();

        public Kunde()
        {
            EinWarenkorb.zurKasse();
        }
    }
}
