using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[5];
            employees[0] = new employee("Hans", "Müller", "Verkauf");
            employees[1] = new employee("Natalie", "Weinfeld", "Verkauf");
            employees[2] = new employee("Pascal", "Merz", "Verkauf");
            employees[3] = new employee("John", "McCullem", "Lager");
            employees[4] = new employee("Jo", "McCullem", "Lager");

            Array.Sort(employees);

            foreach (employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName}\t{employee.LastName}\t\t{employee.Departement}");
            }
            Console.ReadLine();
        }
    }
}
