namespace T1_Console
{
    /// <summary>
    /// Personklasse
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Vorname
        /// </summary>
        public string vorname { get; set; }
        /// <summary>
        /// Nchname
        /// </summary>
        public string nachname { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string eMail { get; set; }

        /// <summary>
        /// Adresse
        /// </summary>
        public Adress Adresse { get; set; }

        /// <summary>
        /// Leere Person erstellen
        /// </summary>
        private Person()
        {

        }
        /// <summary>
        /// Person nur mit Nachnamen erstellen
        /// </summary>
        /// <param name="NAME">nachnamen</param>
        public Person(string NAME)
        {
            nachname = NAME;
        }
        /// <summary>
        /// Person mit Name Vorname EMail und ID erstellen
        /// </summary>
        /// <param name="NAME">nachname</param>
        /// <param name="VORNAME">vorname</param>
        /// <param name="EMAIL">email</param>
        public Person(string NAME, string  VORNAME, string EMAIL)
            :this(NAME)
        {
            eMail = EMAIL;
            vorname = VORNAME;
        }
    }
}
