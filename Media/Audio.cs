using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Audio : IMedia
    {
        public string DisplayMedia()
        {
            return $"{this.GetType().Name}: DisplayMedia() wird nicht unterstützt";
        }

        public string PlayMedia()
        {
            return $"{this.GetType().Name}: Audio wird abgespielt";
        }

        public string StopMedia()
        {
            return $"{this.GetType().Name}: Audio wird gestoppt";
        }
    }
}
