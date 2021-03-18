using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    abstract class Figure
    {
        public Point StartPoint { get; set; }
        public Figure(Point startCoord)
        {
            StartPoint = startCoord;
        }
        public abstract override string ToString();
    }
}
