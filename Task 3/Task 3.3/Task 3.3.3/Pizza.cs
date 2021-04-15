using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{

    class Pizza
    {   
        public string Name { get;}
        public int TimeForCooking { get; }
        public Pizza(string name, int time)
        {
            Name = name;
            TimeForCooking = time;
        }
    }
}
