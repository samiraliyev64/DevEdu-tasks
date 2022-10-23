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

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override double calculateArea()
        {
            double s = (A + B + C) / 2;
            Area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return Area;
        }

        public override double calculatePerimeter()
        {
            Perimeter = A + B + C;
            return Perimeter;
        }
    }
}
