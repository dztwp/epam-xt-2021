using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Square : Rectangle
    {
        public Square(Point StartPoint, Point pointA, Point pointB) : base(StartPoint, pointA, pointB)
        {
            if(SideA.Length!=SideB.Length)
            {
                throw new Exception("Inserted lines have different lengths");
            }
        }
        public override string ToString()
        {
            return "Создан квадрат"+Environment.NewLine+
                "Площадь квадрата - "+GetArea();
        }
    }
}

