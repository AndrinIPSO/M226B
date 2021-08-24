using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Comparable
{
    public class employee : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departement { get; set; }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="firstname">Vorname</param>
        /// <param name="lastname">Nachname</param>
        /// <param name="departement">Departement</param>
        public employee(string firstname, string lastname, string departement)
        {
            Departement = departement;
            LastName = lastname;
            FirstName = firstname;
        }

        public int CompareTo(object obj)
        {
            employee emp = obj as employee;

            if ((FirstName.CompareTo(emp.FirstName) < 0))
                // Diese Instanz ist kleiner als die übergebene,
                // dann muss ein Wert kleiner 0 zurückgegeben  werden 
                return -1;
            else if ((FirstName.CompareTo(emp.FirstName) == 0))
                // Diese Instanz ist gleich der übergebenen, dann
                // muss 0 zurückgegeben werden
                return 0;
            else
                // Diese Instanz ist größer als die übergebene,
                // dann muss ein Wert > 0 zurückgegeben werden
                return 1;
        }

    }
}
