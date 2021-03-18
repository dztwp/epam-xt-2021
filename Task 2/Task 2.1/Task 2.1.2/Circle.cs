using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Circle : Figure
    {

        private double radius;

        public double Circumferrence
        {
            get { return 2 * Math.PI * Radius; }
        }

        public double Radius
        {
            get { return radius; }
            set
            {

                radius = (value > 0) ? value : throw new ArgumentException("Radius must be positive");
            }
        }
        public Circle(Point startPoint, double radius):base(startPoint)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return "Создана окружность" +
                Environment.NewLine +
                "Длина окружности-" + Circumferrence;
        }
    }
}
