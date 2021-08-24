using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto();
            int ip = 5;
            try
            {
                ip = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            switch (ip)
            {
                case (1):

                default:
                    break;
            }
        }
    }
}
