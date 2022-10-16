using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Models
{
    class BMW : Car
    {
        public BMW(string model, double speed, double price, int year, double engine) : base(model, speed, price, year, engine)
        {

        }
        public override void Drift()
        {
            Console.WriteLine("GOD OF DRIFTING!!!!!!!");
        }
        public override void Horn()
        {
            Console.WriteLine("ZOOOOOOOOOOOONKKKKKKK!!!!!!!!!!!!");
        }
    }
}
