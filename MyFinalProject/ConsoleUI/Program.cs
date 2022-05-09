using DataAccess2.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductManager productManager = new ProductManager(new EfProductDal());

        }
    }

   
} 
