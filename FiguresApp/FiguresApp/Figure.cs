using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    public abstract class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public List<Point> Points { get; set; }
        public Point Center { get; set; }
      
        public abstract double calculatePerimeter();
        public abstract double calculateArea();
    }
}
