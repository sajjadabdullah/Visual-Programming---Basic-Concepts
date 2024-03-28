using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011___Exception_Handling_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            try
            {
                int c = a / b;
                int d;
                d = Convert.ToInt32(Console.ReadLine());
                int[] x = new int[5] { 10, 20, 30, 40, 50 };
                Console.WriteLine(x[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Taling from finally block.");
            }

            Console.WriteLine("End of program");
            Console.ReadLine();
        }
    }
}
