using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace assignment_2
{
    

    class Program
    {
        public static void writeProducts()
        {
            var outFile = "/Users/diyar/Desktop/Ramy/Programmering med c#/Inlämningar/assignment_2/assignment_2/file.txt";
            Product product = new Product("Banan", 4, 200);
            Product product1 = new Product("Cola", 15, 300);
            Product product2 = new Product("Cafe", 20, 400);
            Product product3 = new Product("Tomat", 5, 500);

            using (StreamWriter sw = File.CreateText(outFile))
            {
                sw.WriteLine(product.getProductLine());
                sw.WriteLine(product1.getProductLine());
                sw.WriteLine(product2.getProductLine());
                sw.WriteLine(product3.getProductLine());

            }

        }

        public static List<Product> readProducts()
        {
            var inFile = "/Users/diyar/Desktop/Ramy/Programmering med c#/Inlämningar/assignment_2/assignment_2/file.txt";
            var products = new List<Product>();

            using (StreamReader sr = File.OpenText(inFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var product = new Product(line);
                    products.Add(product);
                }
            }
            return products;
        }

        public static void run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("kommandon:");
                    Console.WriteLine("<Produktid>  <Antal>");
                    Console.WriteLine("PAY");
                    Console.Write("Komando:");
                    var produktid = (Console.ReadLine());
                    var antal = (Console.ReadLine());
                    if (produktid == "PAY" && antal =="PAY")
                    {
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Något gick fel försök igen");
                }
            }
           
        }


        static void Main(string[] args)
        {
            var products =readProducts();
            while (true)
            {
                Console.WriteLine("KASSA");
                Console.WriteLine("1. Ny kund");
                Console.WriteLine("0. Avsluta");
                var input = (Console.ReadLine());
                if (input == "1")
                {
                    run();
                }
                else if(input == "0")
                {
                    
                }

                else
                {
                    Console.WriteLine("FEL INMATNING FÖRSÖK IGEN!!");
                }
            }
        }
    }
}
