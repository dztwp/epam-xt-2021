using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Rectangle : FigureWithArea
    {
        private Line _sideOfRectangleA;
        private Line _sideOfRectangleB;

        public Line Diagonal { get; set; }
        public Line SideA
        {
            get { return _sideOfRectangleA; }
            set { _sideOfRectangleA = value; }
        }
        public Line SideB
        {
            get { return _sideOfRectangleB; }
            set { _sideOfRectangleB = value; }
        }



        public Rectangle(Point startPoint, Point pointA, Point pointB):base(startPoint)
        {
            SideA = new Line(StartPoint, pointA);
            SideB = new Line(StartPoint, pointB);
            Diagonal = new Line(pointA, pointB);
            if (Math.Pow(SideA.Length, 2) + Math.Pow(SideB.Length, 2) != Math.Pow(Diagonal.Length, 2))
            {
                throw new Exception("Inserted lines don't form right angle ");
            }
        }

        public override double GetArea()
        {
            return SideA.Length * SideB.Length;
        }

        public override string ToString()
        {
            return "Создан треугольник"+Environment.NewLine+
                "Площадь треугольника - "+GetArea();
        }
    }
}
