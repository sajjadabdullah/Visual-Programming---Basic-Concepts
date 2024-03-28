using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010___Strings_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive data types (value types)
            //reference types (classes)
            //string x = "Government Graduate College Sadiqabad";
            //string y = "House No. 33/A, Street No. 9D, Abc Road, Xyz Colony, Karachi";
            //Console.WriteLine(x);            

            //string x;
            //Console.Write("Write your name: ");
            //x=Console.ReadLine();
            //string y = "Hello, Mr. " + x;
            //Console.WriteLine(y);

            string y = "House No. 33/A, Street No. 9D, Abc Road, Xyz Colony, Karachi";
            string z = "karachi";
            int d = y.IndexOf(z);
            //Console.WriteLine(d);
            if (d >= 0)
            {
                string s1 = y.Substring(d, 7);
                Console.WriteLine(s1);
            }
            else
                Console.WriteLine("String not found.");


            Console.ReadLine();
        }
    }
}
