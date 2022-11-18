using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiguresAppWebAPI.Figures
{
    [Serializable()]
    class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(List<Point> points) : base(points)
        {
            this.A = Math.Pow(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2), 0.5);
            this.B = Math.Pow(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2), 0.5);
            this.C = Math.Pow(Math.Pow(points[2].x - points[0].x, 2) + Math.Pow(points[2].y - points[0].y, 2), 0.5);
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
            double sumX = 0;
            double sumY = 0;
            foreach (var point in Points)
            {
                sumX += point.x;
                sumY += point.y;
            }
            this.Center = new Point(sumX / 3, sumY / 3);
        }
        public override void MoveFigure(double x, double y)
        {
            foreach (var point in Points)
            {
                point.x += x;
                point.y += y;
            }
        }
        public override void RotateFigure(double degree)
        {
            foreach (var point in Points)
            {
                point.x = point.x * Math.Cos(degree) - point.y * Math.Sin(degree);
                point.y = point.y * Math.Cos(degree) + point.x * Math.Sin(degree);
            }
        }
        public override void ScaleFigure(double scale)
        {
            foreach (var point in Points)
            {
                point.x = Center.x - scale * (Center.x - point.x);
                point.y = Center.y - scale * (Center.y - point.y);
            }
            this.CalculateArea();
            this.CalculatePerimeter();
        }
    }
}
