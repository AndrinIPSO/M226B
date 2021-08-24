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

        public double Umfang()
        {
            return Seiten[0] + Seiten[1] + Seiten[2];
        }

        public override string ToString()
        {
            return "Dreieck-" + base.ToString();
        }
    }
}
