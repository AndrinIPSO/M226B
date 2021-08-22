using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wochentagrechner
{
    public class Wochentag
    {
        /// <summary>
        /// Jahr
        /// </summary>
        private int _j;

        public int j
        {
            get { return _j; }
            set { _j = value; }
        }
        /// <summary>
        /// Monat
        /// </summary>
        private int _m;

        public int m
        {
            get { return _m; }
            set { _m = value; }
        }
        /// <summary>
        /// Tag
        /// </summary>
        private int _t;

        public int t
        {
            get { return _t; }
            set { _t = value; }
        }
        /// <summary>
        /// Leerer Wochentag
        /// </summary>
        public Wochentag()
        {

        }
        /// <summary>
        /// Voller Wochentag
        /// </summary>
        /// <param name="t">Tag</param>
        /// <param name="m">Monat</param>
        /// <param name="j">Jahr</param>
        public Wochentag(int t, int m , int j)
        {
            this.t = t;
            this.m = m;
            this.j = j;
        }

        public string GibWochentag()
        {
            DateTime dt = new DateTime(j, m, t);
            return dt.ToString();
        }




    }
}
