using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010___Enums_Practice
{
    class Program
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        static void Main(string[] args)
        {
            //Days d = Days.Monday;
            //if (d == Days.Wednesday)
            //    Console.WriteLine("End of first part of week");
            //else if (d==Days.Saturday)
            //    Console.WriteLine("Weekend in Pakistan.");
            //else if (d == Days.Friday)
            //    Console.WriteLine("Eid of Muslims.");
            //else
            //    Console.WriteLine("Other Days");

            //Console.WriteLine("Enter a day no: ");
            //Console.WriteLine("0-Monday, 1-Tuesday, ");
            //Console.WriteLine("... 6- Sunday ");
            //Days d = (Days)Convert.ToInt32(Console.ReadLine());
            //if (d == Days.Wednesday)
            //    Console.WriteLine("end of first part of week");
            //else if (d == Days.Saturday)
            //    Console.WriteLine("weekend in pakistan.");
            //else if (d == Days.Friday)
            //    Console.WriteLine("eid of muslims.");
            //else
            //    Console.WriteLine("other days");

            foreach (Days item in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
