using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Building
    {
        private string flattype;
        private string capacity;
        private string dimension;
        public int flatno;
        public string landdim;
        private string doc;
        public string Flattype
        {
            get { return flattype; }
            set
            {
                flattype = value;
                if (value == "Flat")
                {
                    Console.WriteLine("Enter the flatno: ");
                    flatno = Convert.ToInt32(Console.ReadLine());
                }
                else if (value == "Villa")
                {
                    Console.WriteLine("Enter the land dimension: ");
                    landdim = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }
        public string Capacity
        {
            get { return capacity; }
            set
            {
                if(value=="2BHK" || value=="3BHK" || value=="4BHK")
                {
                    capacity = value;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }
        public string Dimension
        {
            get { return dimension; }
            set { dimension = value; }
        }

        public string Doc
        {
            get { return doc; }
            set { doc = value; }    
        }

        public Building(string flattype, string capacity, string dimension, string doc)
        {
            Flattype = flattype;
            Capacity = capacity;
            Dimension = dimension;
            Doc = doc;
            
        }

        public void showdata()
        {
            Console.WriteLine("Flattype: "+Flattype);
            if(Flattype=="Flat")
            {
                Console.WriteLine("Flatno: "+flatno);
            }

            else if(Flattype=="Villa")
            {
                Console.WriteLine("land dimension :"+landdim);
            }
            Console.WriteLine("capacity: "+Capacity);
            Console.WriteLine("dimension: "+Dimension);
            Console.WriteLine("Date of completion: " + Doc);
        }
    }
}
