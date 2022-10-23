using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            Square newSquare = new Square(side);
                            double area = newSquare.calculateArea();
                            double perimeter = newSquare.calculatePerimeter();
                            Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");
                            newFiguresInfo += $"Square\nSide: {side}\nArea: {area}\nPerimeter: {perimeter}\n\n";
                            figuresList.Add(newSquare);
                            break;
                        case "b":
                            Console.Write("Enter side 1: ");
                            double side1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter side 2: ");
                            double side2 = Convert.ToDouble(Console.ReadLine());
                            Rectangle newRectangle = new Rectangle(side1, side2);
                            double rectangleArea = newRectangle.calculateArea();
                            double rectanglePerimeter = newRectangle.calculatePerimeter();
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
                            Triangle newTriangle = new Triangle(a, b, c);
                            double triangleArea = newTriangle.calculateArea();
                            double trianglePerimeter = newTriangle.calculatePerimeter();
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
                    Console.WriteLine("change figure");
                }
                else if (userInput == "4")
                {
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
