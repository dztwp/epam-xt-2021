using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{

    class Pizza
    {   
        public string Name { get; set; }
        public string Size { get; }
        public Pizza(string name, string size)
        {
            Name = name;
            Size = size;
        }
    }
}
