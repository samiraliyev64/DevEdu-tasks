using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    class Rectangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2, List<Point> points) : base(points)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public override double CalculateArea()
        {
            Area = Side1 * Side2;
            return Area;
        }

        public override double CalculatePerimeter()
        {
            Perimeter = 2 * (Side1 + Side2);
            return Perimeter;
        }
        public override void FindCenter()
        {
            throw new NotImplementedException();
        }
        public override void MoveFigure(double x, double y)
        {
            throw new NotImplementedException();
        }
        public override void RotateFigure(double degree)
        {
            throw new NotImplementedException();
        }
        public override void ScaleFigure(double scale)
        {
            throw new NotImplementedException();
        }
    }
}
