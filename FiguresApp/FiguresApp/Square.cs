using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    class Square : Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double calculateArea()
        {
            Area = Side * Side;
            return Area; 
        }

        public override double calculatePerimeter()
        {
            Perimeter = 4 * Side;
            return Perimeter;
        }
    }
}
