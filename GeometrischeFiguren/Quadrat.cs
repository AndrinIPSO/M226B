using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    public class Quadrat : Rechteck
    {
        public Quadrat(double[] s)
            : base(s)
        {

        }

        public double QuadratFläche()
        {
            return base.Multiplikation(base.Seiten[0], base.Seiten[0]);
        }
    }
}
