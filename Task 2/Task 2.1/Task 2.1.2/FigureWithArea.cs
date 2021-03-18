using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    abstract class FigureWithArea : Figure
    {
        public FigureWithArea(Point start):base(start)
        {

        }
        abstract public double GetArea();

    }
}
