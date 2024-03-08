using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___Structures_Practice
{
    class Program
    {
        struct Book
        {
            public string Title;
            public int Pages;
            public double Price;

            public Book(string title, int pages, double price)
            {
                Title = title;
                Pages = pages;
                Price = price;
            }

            public void print()
            {
                Console.WriteLine($"Title={Title}");
                Console.WriteLine($"Pages={Pages}");
                Console.WriteLine($"Price={Price}");
            }
        }

        static Book GetExpensiveBook(Book b1, Book b2)
        {
            Book x;
            if (b1.Price > b2.Price)
                x = b1;
            else
                x = b2;

            return x;
        }

        static void Main(string[] args)
        {
            Book a = new Book("Data Structures",1000,30.5);
            Book b = new Book("Intro to C#", 500, 35.5);
            Console.WriteLine("Book 1 Details");
            a.print();
            Console.WriteLine("Book 2 Details");
            b.print();

            Book exBook = GetExpensiveBook(a, b);
            Console.WriteLine("Expense Book Details");
            exBook.print();

            Console.ReadLine();
        }
    }
}
