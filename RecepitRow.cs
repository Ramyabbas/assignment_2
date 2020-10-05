using System;
using System.Collections.Generic;

namespace assignment_2
{
    public class RecepitRow
    {
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public int Price { get; private set; }
        public int Sum { get; private set; }

        public RecepitRow(string productname, int quantity, int price)
        {
            ProductName = productname;
            Quantity = quantity;
            Price = price;
            Sum = price * quantity;
        }
        public void printRow()
        {
            Console.WriteLine($"{ProductName} {Quantity} * {Price}kr = {Sum}kr ");

        }
    }
}
