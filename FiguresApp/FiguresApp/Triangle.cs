using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c,List<Point> points) : base(points)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override double CalculateArea()
        {
            double s = (A + B + C) / 2;
            Area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return Area;
        }

        public override double CalculatePerimeter()
        {
            Perimeter = A + B + C;
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
