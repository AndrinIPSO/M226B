using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adressen
            Adress a1 = new Adress()
            {
                strasse = "strassenstrasse",
                hausnr = "1b",
                ort = "zurzach",
                PLZ = "0111"
            };
            Adress a2 = new Adress()
            {
                strasse = "strasssse",
                hausnr = "12b",
                ort = "BC",
                PLZ = "8965"
            };
            #endregion

            #region student instanziieren und adresse hinzufügen
            Student s1 = new Student( "123123", 1,"Schellenberg", "Andrin", "mail@gmx.com");
            s1.Adresse = a1;
            #endregion

            #region Professor instanziieren und adresse hinzufügen
            Professor p1 = new Professor("11212", 1200, "Gates", "Bill", "billgates@outlook.com");
            p1.Adresse = a2;
            #endregion

            #region Kurs instanziieren und zuteilen
            Kurs k1 = new Kurs("6969", p1);
            p1.Kurse.Add(k1);
            k1.Schueler.Add(s1);
            s1.Kurse.Add(k1);
            #endregion

        }
    }
}
