using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    class Program
    {
        static void Main(string[] args)
        {

            List<GeomFigure> Figuren = new List<GeomFigure>();

            Rechteck r = new Rechteck(new double[] { 10.0, 20.0 });
            Dreieck d = new Dreieck(new double[] { 10.0, 20.0, 30.0 });
            Quadrat q = new Quadrat(new double[] { 10.0 });

            Figuren.Add(r);
            Figuren.Add(d);
            Figuren.Add(q);

            foreach (var geomfigure in Figuren)
            {
                Console.WriteLine(geomfigure.ToString());
                Console.WriteLine("Umfang: " + geomfigure.Umfang());
                Console.WriteLine($"Fläche: {geomfigure.Fläche()}");
                geomfigure.Draw();
            }

            //Console.WriteLine($"Rechteckfläche={r.RechteckFläche()}");
            //Console.WriteLine(r.ToString());

            //Console.WriteLine($"Dreieckumfang={d.Umfang()}");
            //Console.WriteLine(d.ToString());

            //Console.WriteLine($"Quadratfläche={q.QuadratFläche()}");
            //Console.WriteLine(q.ToString());


            Console.ReadKey();
        }
    }
}
