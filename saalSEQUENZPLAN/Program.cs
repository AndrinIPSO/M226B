using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saalSEQUENZPLAN
{
    class Program
    {
        static void Main(string[] args)
        {
            saalplan aSaalplan = new saalplan();
            Bestellung aBestellung = new Bestellung(aSaalplan);
            verkauf aVerkauf = new verkauf(aBestellung);

            aSaalplan.Verkauf = aVerkauf;
            Platz aPlatz = new Platz(aBestellung);



        }
    }
}
