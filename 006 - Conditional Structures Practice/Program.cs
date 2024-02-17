using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006___Conditional_Structures_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //if Statement
            //int n = -4;
            //if (n >= 0)
            //{
            //    Console.WriteLine("Positive Number");
            //}

            //another example
            //int a, b, c, mx;
            //a = 10;
            //b = 20;
            //c = 30;
            //mx = a;
            //if (b > mx)
            //    mx = b;
            //if (c > mx)
            //    mx = c;
            //Console.WriteLine($"Maximum value is {mx}.");

            //if-else
            //int marks = 75;
            //if (marks >= 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //if-else if-else
            //float percent = 71.55f;
            //string grade = "";
            //if (percent >= 90)
            //    grade = "A+";
            //else if (percent >= 80)
            //    grade = "A";
            //else if (percent >= 70)
            //    grade = "B";
            //else if (percent >= 60)
            //    grade = "C";
            //else if (percent >= 50)
            //    grade = "D";
            //else
            //    grade = "F";
            //Console.WriteLine($"Grade is {grade}");

            //switch example
            //int dn = 9;
            //string dname = "";
            //switch(dn)
            //{
            //    case 1: dname = "Monday"; break;
            //    case 2: dname = "Tuesday"; break;
            //    case 3: dname = "Wednesday"; break;
            //    case 4: dname = "Thursday"; break;
            //    case 5: dname = "Friday"; break;
            //    case 6: dname = "Saturday"; break;
            //    case 7: dname = "Sunday"; break;
            //    default: dname = "Invalid Day No."; break;
            //}
            //Console.WriteLine($"Day Name is {dname}");

            //Conditional Operator
            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = (a > b) ? a : b;
            //Console.WriteLine($"Maximum value is {c}");

            //for loop
            //int n, i, r;
            //n = 4;
            //for (i = 1; i <= 10; i++)
            //{
            //    r = n * i;
            //    Console.WriteLine($"{n} x {i} = {r}");
            //}

            //while loop
            //int n, i, r;
            //n = 7;
            //i = 1;
            //while(i<=10)
            //{
            //    r = n * i;
            //    Console.WriteLine($"{n} x {i} = {r}");

            //    i++;
            //}

            //do-while loop
            int n, i, r;
            n = 7;
            i = 1;
            do
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }                   

                r = n * i;
                Console.WriteLine($"{n} x {i} = {r}");

                i++;
            } while (i <= 10) ;





                Console.ReadLine();
        }
    }
}
