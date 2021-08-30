using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Console
{
    /// <summary>
    /// Professorenklasse
    /// </summary>
    public class Professor : Person
    {
        public double salaer { get; set; }
        /// <summary>
        /// AHVNUMMER
        /// </summary>
        public string ahvnummer { get; set; }
        /// <summary>
        /// Kurse
        /// </summary>
        public List<Kurs> Kurse = new List<Kurs>();

        /// <summary>
        /// Professor als person
        /// </summary>
        /// <param name="NAME"></param>
        public Professor(string NAME)
            : base(NAME)
        {

        }
        /// <summary>
        /// professor als volle Person
        /// </summary>
        /// <param name="NAME">nachname</param>
        /// <param name="VORNAME">vorname</param>
        /// <param name="MAIL">email</param>
        public Professor(string NAME, string VORNAME, string MAIL)
            :base(NAME, VORNAME, MAIL)
        {

        }
        /// <summary>
        /// professor mit AHV
        /// </summary>
        /// <param name="AHVNR">ahvnr</param>
        /// <param name="NAME">nachname</param>
        /// <param name="VORNAME">vorname</param>
        /// <param name="EMAIL">email</param>
        public Professor(string AHVNR, double SALEAR, string NAME, string VORNAME, string EMAIL)
            :base(NAME, VORNAME, EMAIL)
        {
            ahvnummer = AHVNR;
            salaer = SALEAR;
        }
    }
}
