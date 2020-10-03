using System;
using System.Collections.Generic;

namespace assignment_2
{
    public class RecepitRow
    {
        public int Quantity { get; private set; }
        public int Price { get; private set; }
        public Product product { get; set; }
        public RecepitRow()
        {

        }
    }
}
