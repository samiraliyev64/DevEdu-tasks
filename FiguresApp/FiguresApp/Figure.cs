using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FiguresApp
{
    [Serializable()]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [XmlRoot(Namespace = "FiguresApp")]

    public abstract class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public List<Point> Points { get; set; }
        public Point Center { get; set; }
        public Figure(List<Point> points)
        {
            this.Points = points;
            this.CalculateArea();
            this.CalculatePerimeter();
            this.FindCenter();
        }
        
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public abstract void MoveFigure(double x, double y);
        public abstract void RotateFigure(double degree);
        public abstract void ScaleFigure(double scale);
        public abstract void FindCenter();
    }
}
