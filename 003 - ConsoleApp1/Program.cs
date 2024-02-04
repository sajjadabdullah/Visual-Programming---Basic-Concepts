using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome Class");
            //Console.Write("Visual Programming is Interesting");
            //string n="Pakistan";
            //Console.WriteLine(n);

            //string n;
            //n=Console.ReadLine();
            //Console.WriteLine(n);

            //int age;
            //age= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your age is {age}.");

            double n1, n2, sum, prod;
            Console.Write("Please enter first number. ");
            n1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second number. ");
            n2 = Convert.ToDouble(Console.ReadLine());
            sum = n1 + n2;
            prod = n1 * n2;
            Console.WriteLine($"Sum={sum}");
            Console.WriteLine($"Product={prod}");


            Console.ReadLine();
        }
    }
}
