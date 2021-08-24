﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren
{
    public class GeomFigure
    {
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

    }
}