using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Picture : IMedia
    {
        public string DisplayMedia()
        {
            return $"{this.GetType().Name}: Bild wird angezeigt";
        }

        public string PlayMedia()
        {
            return $"{this.GetType().Name}: Die Methode PlayMedia() wird nicht unterstützt";
        }

        public string StopMedia()
        {
            return $"{this.GetType().Name}: Die Methode StopMedia() wird nicht unterstützt";
        }
    }
}
