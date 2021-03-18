using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Ring:FigureWithArea
    {
        Circle innerCircle;
        Circle outerCircle;
        public Ring(Point startPoint,double innerRadius, double outerRadius):base(startPoint)
        {
            innerCircle = new Circle(StartPoint, innerRadius);
            outerCircle = new Circle(StartPoint, outerRadius);
            if(innerCircle.Radius>outerCircle.Radius)
            {
                throw new ArgumentException("Внутренний радиус должен быть меньше внешнего");
            }    
        }


        public double SumOfCircumferrence
        {
            get { return outerCircle.Circumferrence+ innerCircle.Circumferrence; }
        }

        public override double GetArea()
        {
            return Math.Pow(outerCircle.Radius,2)*Math.PI - Math.Pow(innerCircle.Radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            return "Создано кольцо"+Environment.NewLine+
                "Длина окружностей внешнего и внутреннего колец - "+SumOfCircumferrence+Environment.NewLine+
                "Площадь кольца - "+GetArea();
        }
    }
}
