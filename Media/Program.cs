using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video();
            Picture p = new Picture();
            Audio a = new Audio();

            List<IMedia> medien = new List<IMedia>();
            medien.Add(a);
            medien.Add(p);
            medien.Add(v);


            int i = 1;
            foreach (var tmp in medien)
            {
                Console.WriteLine($"Medium: {i}");
                Console.WriteLine(tmp.DisplayMedia());
                Console.WriteLine(tmp.PlayMedia());
                Console.WriteLine(tmp.StopMedia());
                i++;
            }
            Console.Read();
        }
    }
}
