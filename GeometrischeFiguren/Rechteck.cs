using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    public class Rechteck : GeomFigure
    {
        public Rechteck(double[] s)
            :base(s)
        {

        }

        public double RechteckFläche()
        {
            return this.Multiplikation(base.Seiten[0], base.Seiten[1]);
        }

        protected double Multiplikation(double a, double b)
        {
            return a * b;
        }

        public override string ToString()
        {
            return "Rechteck-" + base.ToString();
        }
        public override double Umfang()
        {
            return base.Umfang() * 2;
        }

        public override double Fläche()
        {
            return Seiten[0] * Seiten[1];
        }

    }
}
