using System;
using System.Collections.Generic;
namespace assignment_2
{
    public class Recepit
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public DateTime dateTime { get; private set; }
        
        public RecepitRow row { get; set; }

        public Recepit()
        {
        }
    }
}
