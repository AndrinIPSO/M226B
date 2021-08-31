using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            trainer.club = "FCM";


            Sportchef sportchef = new Sportchef();
            sportchef.verein = "FCM";
            sportchef.trainer = trainer;

            for (int i = 0; i < 11; i++)
            {
                trainer.spieler.Add(new Feldspieler());
            }

            trainer.spieler.Add(new Torwart());
            sportchef.trainieren();

            Console.ReadLine();
        }
    }
}
