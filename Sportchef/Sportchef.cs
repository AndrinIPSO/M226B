using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportchef
{
    public class Sportchef
    {
        public string verein { get; set; }
        public Trainer trainer { get; set; }

        public void trainieren()
        {
            trainer.trainieren();
        }
    }
}
