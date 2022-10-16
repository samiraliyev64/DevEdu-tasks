using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Models
{
    class Mercedes : Car
    {
        public Mercedes(string model, double speed, double price, int year, double engine) : base(model,speed,price,year,engine)
        {

        }
        public override void Drift()
        {
            Console.WriteLine("Mercedes sucks in drifting :D");
        }
        public override void Horn()
        {
            base.Horn();
        }
    }

}
