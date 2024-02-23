using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Functions_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car.Greet();
            Car c1=new Car(); //object is declared & initialized in memory
            c1.Greet(20, '%');
            int z = c1.Sum(10, 20);
            Console.WriteLine($"Sum is {z} inside Main function.");

            Console.ReadLine();
        }
    }

    class Car
    {
        public void Greet(int n, char ch)
        {
            for (int i = 1; i <= n; i++)
                Console.Write($"{ch}");
            Console.WriteLine("\nWelcome BS 5th");
        }

        public int Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Sum={c}");
            return c;
        }


    }
}
