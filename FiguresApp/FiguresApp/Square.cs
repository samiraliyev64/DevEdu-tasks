using System;
using System.Collections.Generic;

namespace FiguresApp
{
    [Serializable()]
    class Square : Figure
    {
        public double Side { get; set; }
        public Square(List<Point> points) : base(points)
        {
            //this.Side = points[0].y - points[1].y;
            this.Side = Math.Pow(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2), 0.5);
        }
        public override double CalculateArea()
        {
            Area = Side * Side;
            return Area; 
        }
        public override double CalculatePerimeter()
        {
            Perimeter = 4 * Side;
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
            this.Center = new Point(sumX / 4, sumY / 4);
        }
        public override void MoveFigure(double x, double y)
        {
            foreach (var point in Points)
            {
                point.x += x;
                point.y += y;
                Console.WriteLine($"({point.x} , {point.y})");
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
        public override string ToString()
        {
            return $"Square\nSide: {Side}\nArea: {Area}\nPerimeter: {Perimeter}";
        }
    }
}
