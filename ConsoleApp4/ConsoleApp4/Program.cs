using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Person p = new Person("Blessy", "John", "qer@gmail.com");
                Person r = new Person("Grace", "John", new DateTime(2022, 12, 12));
               Console.WriteLine(p.lastname);
                Console.WriteLine(r.dob);  */

            Building b = new Building("Flat", "4BHK", "THREE", "January");
            b.showdata();
        }
    }
}
