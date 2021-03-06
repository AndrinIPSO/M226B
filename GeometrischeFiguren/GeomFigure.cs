using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    public abstract class GeomFigure : IDraw
    {
        public string Color { get; set; }

        protected double[] _Seiten;

        public double[] Seiten
        {
            get { return _Seiten; }
            set { _Seiten = value; }
        }

        

        public GeomFigure(double[] seiten)
        {
            _Seiten = seiten;
        }

        public override string ToString()
        {
            string result = "Seitenlängen: ";
            foreach (var d in Seiten)
            {
                result = result + " " + d;
            }
            return result;
        }

        public virtual double Umfang()
        {

            // Seiten.sum()
            double tmp = 0;
            foreach (double seite in Seiten)
            {
                tmp += seite;
            }
            return tmp;
        }

        public virtual double Fläche()
        {
            return 0.0;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw in Farbe {Color}");
        }
    }
}
