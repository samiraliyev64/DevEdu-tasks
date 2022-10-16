using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Models
{
    class Audi : Car
    {
        public Audi(string model, double speed, double price, int year, double engine) : base(model,speed,price,year,engine)
        {

        }
        public override void Drift()
        {
            Console.WriteLine("Audi is meh in drifting");
        }
        public override void Horn()
        {
            Console.WriteLine("Horn is broken");
        }
    }
}
