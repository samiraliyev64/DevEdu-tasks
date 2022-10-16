using ClassPractice.Models;
using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw1 = new BMW("E39", 235, 40.500, 2010, 2.3);
            Console.WriteLine("-------------  BMW ----------------------");
            bmw1.DisplayInfo();
            bmw1.Drift();
            bmw1.Horn();

            Mercedes mercedes1 = new Mercedes("GLS 350", 200, 69.000, 2018, 3.0);
            Console.WriteLine("-------------- Mercedes ------------------------");
            mercedes1.DisplayInfo();
            mercedes1.Drift();
            mercedes1.Horn();

            Audi audi1 = new Audi("A7", 195, 40.000, 2015, 3.0);
            Console.WriteLine("-------------- Audi ------------------------");
            audi1.DisplayInfo();
            audi1.Drift();
            audi1.Horn();
            Console.ReadKey();
        }
    }
}
