using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Console
{
    /// <summary>
    /// Studentklasse
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Kurse
        /// </summary>
        public List<Kurs> Kurse = new List<Kurs>();
        /// <summary>
        /// studiensemester
        /// </summary>
        public int studiensemester { get; set; }
        /// <summary>
        /// Leginr
        /// </summary>
        public string legiNummer { get; set; }
        /// <summary>
        /// Student mit nur Namen erstellen
        /// </summary>
        /// <param name="NAME"></param>
        public Student(string NAME)
            :base(NAME)
        {

        }
        /// <summary>
        /// Student als volle Person erstellen
        /// </summary>
        /// <param name="NAME">nachname</param>
        /// <param name="VORNAME">vorname</param>
        /// <param name="MAIL">email</param>
        public Student(string NAME, string VORNAME, string MAIL)
            :base(NAME, VORNAME, MAIL)
        {
            
        }

        /// <summary>
        /// Voller Shüler erstellen
        /// </summary>
        /// <param name="LEGINR">leginr</param>
        /// <param name="SEMESTER">semester</param>
        /// <param name="NAME">nachname</param>
        /// <param name="VORNAME">vorname</param>
        /// <param name="EMAIL">email</param>
        public Student(string LEGINR, int SEMESTER, string NAME, string VORNAME, string EMAIL)
            :base(NAME,VORNAME,EMAIL)
        {
            legiNummer = LEGINR;
            studiensemester = SEMESTER;
        }


    }
}
