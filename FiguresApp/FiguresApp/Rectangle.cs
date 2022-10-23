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

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public override double calculateArea()
        {
            Area = Side1 * Side2;
            return Area;
        }

        public override double calculatePerimeter()
        {
            Perimeter = 2 * (Side1 + Side2);
            return Perimeter;
        }
    }
}
