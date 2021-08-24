using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    interface IReadWrite
    {
        double Kontostand(double amount);
    }
}
