using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Triangle : FigureWithArea
    {
        private Line _firstLine;
        private Line _secondLine;
        private Line _thirdLine;


        private double HalfPerimeter => 0.5 * (FirstLine.Length + SecondLine.Length + ThirdLine.Length);
        public Line FirstLine
        {
            get { return _firstLine; }
            set { _firstLine = value; } //убрать свойства
        }
        public Line SecondLine
        {
            get { return _secondLine; }
            set { _secondLine = value; }
        }
        public Line ThirdLine
        {
            get { return _thirdLine; }
            set { _thirdLine = value; }
        }

        public override double GetArea()
        {
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstLine.Length) * (HalfPerimeter - SecondLine.Length) * (HalfPerimeter - ThirdLine.Length));
        }
        public Triangle(Point startPoint,Point pointA, Point pointB):base(startPoint)
        {
            FirstLine = new Line(startPoint, pointA);
            SecondLine = new Line(startPoint, pointB);
            ThirdLine = new Line(pointA, pointB);
        }
        public override string ToString()
        {
            return "Создан треугольник"+Environment.NewLine+
                "Длина первой стороны - "+FirstLine.Length+ Environment.NewLine+
                "Длина второй стороны - " + SecondLine.Length + Environment.NewLine +
                "Длина третьей стороны - " + ThirdLine.Length + Environment.NewLine +
                "Площадь треугольника - " + GetArea();
        }
    }
}
