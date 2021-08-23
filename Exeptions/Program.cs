using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int z1;
            int z2;
             
            Console.WriteLine("Bitte Zhal eingeben:");
            string eingabe = Console.ReadLine();

            try
            {
                z1 = Convert.ToInt32(eingabe);
                if (z1 == 13)
                {
                    throw new Exception($"ungültige Zahl({z1})");
                }
                z2 = 100 / z1;
                Console.WriteLine($"Zahl1:{z1} Zahl2:{z2}");
                
            }

            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Format Exeption: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Overflow Exeption: {e.Message}");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unbekannter Fehler: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
