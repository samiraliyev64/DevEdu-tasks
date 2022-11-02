using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FiguresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\HP\Desktop\DevEdu-tasks\FiguresApp\figures.txt";
            string newFiguresInfo = "";
            List<Figure> figuresList = new List<Figure>();
            while (true)
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. Show all figures");
                Console.WriteLine("2. Create a figure");
                Console.WriteLine("3. Change a figure:\n\ta)move figure\n\tb)rotate figure\n\tc)scale figure\n");
                Console.WriteLine("4. Save to file");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose from menu: ");
                string userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    Environment.Exit(0);
                }
                else if (userInput == "1")
                {
                    string[] lines = File.ReadAllLines(@"C:\Users\HP\Desktop\DevEdu-tasks\FiguresApp\figures.txt");
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    //binary
                    Stream openFileStream = File.OpenRead(filePath);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    List<Figure> myFiguresList = (List<Figure>)deserializer.Deserialize(openFileStream);
                    openFileStream.Close();

                    //xml
                    //var mySerializer = new XmlSerializer(typeof(List<Figure>));
                    //var myFileStream = new FileStream(filePath, FileMode.Open);
                    //var myObject = (List<Figure>)mySerializer.Deserialize(myFileStream);
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("a. square");
                    Console.WriteLine("b. rectangle");
                    Console.WriteLine("c. triangle");
                    Console.Write("\nChoose option: ");
                    string figureName = Console.ReadLine();

                    switch (figureName)
                    {
                        case "a":
                            Console.Write("Enter side: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            List<Point> points = new List<Point>()
                            {
                                new Point(0,0),
                                new Point(0,4),
                                new Point(4,4),
                                new Point(4,0)
                            };
                            Square newSquare = new Square(points);
                            double area = newSquare.CalculateArea();
                            double perimeter = newSquare.CalculatePerimeter();
                            Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");
                            newFiguresInfo += $"Square\nSide: {side}\nArea: {area}\nPerimeter: {perimeter}\n";
                            foreach (var point in newSquare.Points)
                            {
                                newFiguresInfo += $"({point.x} , {point.y})";
                            }
                            Console.WriteLine("\n\n");
                            figuresList.Add(newSquare);
                            break;
                        case "b":
                            Console.Write("Enter side 1: ");
                            double side1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter side 2: ");
                            double side2 = Convert.ToDouble(Console.ReadLine());
                            List<Point> pointsRectangle = new List<Point>()
                            {
                                new Point(0,0),
                                new Point(0,6),
                                new Point(6,10),
                                new Point(12,10)
                            };
                            Rectangle newRectangle = new Rectangle(pointsRectangle);
                            double rectangleArea = newRectangle.CalculateArea();
                            double rectanglePerimeter = newRectangle.CalculatePerimeter();
                            Console.WriteLine($"Area: {rectangleArea}, Perimeter: {rectanglePerimeter}");
                            newFiguresInfo += $"Rectangle\nSide 1: {side1}\nSide 2: {side2}\nArea: {rectangleArea}\nPerimeter: {rectanglePerimeter}\n\n";
                            figuresList.Add(newRectangle);
                            break;
                        case "c":
                            Console.Write("Enter side a: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter side b: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter side c: ");
                            double c = Convert.ToDouble(Console.ReadLine());
                            List<Point> pointsTriangle = new List<Point>()
                            {
                                new Point(0,0),
                                new Point(0,4),
                                new Point(4,4)
                            };
                            Triangle newTriangle = new Triangle(pointsTriangle);
                            double triangleArea = newTriangle.CalculateArea();
                            double trianglePerimeter = newTriangle.CalculatePerimeter();
                            Console.WriteLine($"Area: {triangleArea}, Perimeter: {trianglePerimeter}");
                            newFiguresInfo += $"Triangle\nSide 1: {a}\nSide 2: {b}\nSide 3: {c}\nArea: {triangleArea}\nPerimeter: {trianglePerimeter}\n\n";
                            figuresList.Add(newTriangle);
                            break;
                        default:
                            Console.WriteLine("there is no such figure");
                            break;
                    }
                }
                else if (userInput == "3")
                {
                    Console.Write("Choose option a,b,c:  ");
                    string yourOption = Console.ReadLine();

                    switch (yourOption)
                    {
                        case "a":
                            Console.Write("Choose figure: ");
                            int optionFigure = Convert.ToInt32(Console.ReadLine());
                            for (int i=0; i < figuresList.Count;i++)
                            {
                                if(optionFigure == i+1)
                                {
                                    Figure currentFigure = figuresList[i];
                                    Console.Write("Enter x: ");
                                    double x = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Enter y: ");
                                    double y = Convert.ToDouble(Console.ReadLine());
                                    currentFigure.MoveFigure(x, y);
                                    foreach (var point in currentFigure.Points)
                                    {
                                        point.x += x;
                                        point.y += y;
                                    }
                                }
                            }
                            break;
                        case "b":
                            Console.Write("Choose figure: ");
                            int optionFigureRotate = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < figuresList.Count; i++)
                            {
                                if (optionFigureRotate == i + 1)
                                {
                                    Figure currentFigure = figuresList[i];
                                    Console.Write("Enter degree: ");
                                    double degree = Convert.ToDouble(Console.ReadLine());
                                    currentFigure.RotateFigure(degree);
                                }
                            }
                            break;
                        case "c":
                            Console.Write("Choose figure: ");
                            int optionFigureScale = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < figuresList.Count; i++)
                            {
                                if (optionFigureScale == i + 1)
                                {
                                    Figure currentFigure = figuresList[i];
                                    Console.Write("Enter scale: ");
                                    double scale = Convert.ToDouble(Console.ReadLine());
                                    currentFigure.RotateFigure(scale);
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("there is no such figure");
                            break;
                    }
                }
                else if (userInput == "4")
                {
                    //binary
                    Stream fileStream = File.Create(filePath);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(fileStream, figuresList);
                    fileStream.Close();

                    //xml
                    //XmlSerializer mySerializer = new XmlSerializer(typeof(List<Figure>));
                    //StreamWriter Writer = new StreamWriter(filePath);
                    //mySerializer.Serialize(Writer, figuresList);
                    //Writer.Close();

                    Console.WriteLine("saved to file");
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(newFiguresInfo);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            
            Console.ReadKey();
        }
    }
}
