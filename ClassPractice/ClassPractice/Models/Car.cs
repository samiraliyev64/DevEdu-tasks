using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Models
{
    class Car
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public double _speed;
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _year; 
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private double _engine;
        public double Engine
        {
            get { return _engine; }
            set { _engine = value;}
        }
        public Car(string model, double speed, double price, int year, double engine)
        {
            this.Model = model;
            this.Speed = speed;
            this.Price = price;
            this.Year = year;
            this.Engine = engine;
        }
        public void Accelerate()
        {
            Console.WriteLine("Speed increase by 15 km/h");
            this.Speed += 15;
        }
        public void Accelerate(int increaseValue)
        {
            Console.WriteLine($"Speed increase by {increaseValue} km/h");
            this.Speed += increaseValue;
        }
        public void Brake()
        {
            Console.WriteLine("Speed decrease by 15 km/h");
            this.Speed -= 15;
        }
        public void Brake(int decreaseValue)
        {
            Console.WriteLine($"Speed decrease by {decreaseValue} km/h");
            this.Speed -= decreaseValue;
        }
        public virtual void Drift()
        {
            Console.WriteLine("Default cars can not be used for drifting");
        }
        public virtual void Horn()
        {
            Console.WriteLine("BEEPPP!!!");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {this.Model}\nEngine: {this.Engine} L\nSpeed: {this.Speed} km/h" +
                              $"\nPrice: {this.Price}K $\nYear: {this.Year}");
        }

    }
}
