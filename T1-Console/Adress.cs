namespace T1_Console
{
    /// <summary>
    /// Adressklasse
    /// </summary>
    public class Adress
    {
        /// <summary>
        /// ort
        /// </summary>
        public string ort { get; set; }
        /// <summary>
        /// plz
        /// </summary>
        public string PLZ { get; set; }
        /// <summary>
        /// strasse
        /// </summary>
        public string strasse { get; set; }
        /// <summary>
        /// hausnr
        /// </summary>
        public string hausnr { get; set; }

        /// <summary>
        /// Leere Adresse
        /// </summary>
        public Adress()
        {

        }
        /// <summary>
        /// Adresse mit strasse und nr
        /// </summary>
        /// <param name="STRASSE">strasse</param>
        /// <param name="HAUSNR">hausnr</param>
        public Adress(string STRASSE, string HAUSNR)
        {
            hausnr = HAUSNR;
            strasse = STRASSE;
        }
    }
}
