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
        public override string ToString()
        {
            return "Quadrat-" + base.ToString();
        }

        public override double Umfang()
        {
            return base.Umfang() * 2;
        }

        public override double Fläche()
        {
            return Seiten[0] * Seiten[0];
        }
    }
}
