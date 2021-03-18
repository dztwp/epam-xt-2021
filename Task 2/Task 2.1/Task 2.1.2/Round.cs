using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Round : FigureWithArea
    {
        Circle _circle;
        public Round(Point startPoint, double radius):base(startPoint)
        {
            _circle = new Circle(StartPoint, radius);    
        }

        public override double GetArea()
        {
            return Math.Pow(_circle.Radius,2)*Math.PI;
        }

        public override string ToString()
        {
            return "Создан круг" + Environment.NewLine +
                "Площадь круга - " + GetArea();
        }
    }
}
