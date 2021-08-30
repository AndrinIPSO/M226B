using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Console
{
    /// <summary>
    /// Kursklasse
    /// </summary>
    public class Kurs
    {
        /// <summary>
        /// Kurs ID
        /// </summary>
        public string identifikationsnummer { get; set; }
        /// <summary>
        /// Kurs Professor
        /// </summary>
        public Professor professor { get; set; }
        /// <summary>
        /// Schueler
        /// </summary>
        public List<Student> Schueler = new List<Student>();

        /// <summary>
        /// Kurs mit id erstellen
        /// </summary>
        /// <param name="ID">kursid</param>
        public Kurs(string ID)
        {
            identifikationsnummer = ID;
        }
        /// <summary>
        /// kurs mit id und professor erstellen
        /// </summary>
        /// <param name="ID">id</param>
        /// <param name="PROFESSOR">professor</param>
        public Kurs(string ID, Professor PROFESSOR)
            :this(ID)
        {
            professor = PROFESSOR;
        }
    }
}
