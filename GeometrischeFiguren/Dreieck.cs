using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    public class Dreieck : GeomFigure
    {
        public Dreieck(double[] s)
            : base(s)
        {

        }



        public override string ToString()
        {
            return "Dreieck-" + base.ToString();
        }

        public override double Fläche()
        {
            return Seiten[0] * Seiten[0] / 2;
        }
    }
}
