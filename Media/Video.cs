using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Video : IMedia
    {
        public string DisplayMedia()
        {
            return $"{this.GetType().Name}: Videobild wird angezeigt";
        }

        public string PlayMedia()
        {
            return $"{this.GetType().Name}: Video wird abgespielt";
        }

        public string StopMedia()
        {
            return $"{this.GetType().Name}: Video wird gestoppt";
        }
    }
}
