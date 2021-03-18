using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Line : Figure
    {
        private Point _endPoint;
        public Point EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }

        public Line(Point startPoint, Point endPoint):base(startPoint)
        {
            EndPoint = endPoint;
        }
        public double Length
        {
            get { return Math.Sqrt((Math.Pow(EndPoint.X, 2) - Math.Pow(StartPoint.X, 2)) + (Math.Pow(EndPoint.Y, 2) - Math.Pow(StartPoint.Y, 2))); }
        }

        public override string ToString()
        {
            return "Создана линия"+Environment.NewLine+
                "Длина линии - "+Length;
        }
    }
}


