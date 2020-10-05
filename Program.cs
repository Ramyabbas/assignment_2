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

        public static int searchProducts(int productid, List<Product> products)
        {
            int position = -1;

            for (int i=0; i< products.Count; i++)
            {
                if (productid == products[i].ID)
                {
                    position = i;
                }
            }
            return position;
        }

        public static void run(List<Product> products)
        {
            var recepitRows = new List<RecepitRow>();
            while (true)
            {
                try
                {

                    Console.WriteLine("kommandon:");
                    Console.Write("<Produktid>");
                    Console.Write(" < Antal >");
                    Console.WriteLine("PAY");
                    Console.Write("Komando:");
                    int produktid = Convert.ToInt32(Console.ReadLine());
                    int antal = Convert.ToInt32(Console.ReadLine());
                    var product = products.Find(p => p.ID == produktid);
                    var receiptRow = new RecepitRow(product.Name, antal, product.Price);
                    recepitRows.Add(receiptRow);
                    foreach(var recepitrow in recepitRows) 
                    {
                        recepitrow.printRow();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
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
                    run(products);
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
