using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    class Pentagon
    {
        private double side;

        public Pentagon()
        {
            this.side = 0;
        }

        public Pentagon(Pentagon p)
        {
            side = p.side;
        }
        public Pentagon(double side)
        {
            //Console.WriteLine(String.Format("I'm initializing a new pentagon instance with a side length of {0}.", side));
            this.side = side;
        }

        public double CalculateArea()
        {
            return ((5 * Math.Pow(this.side, 2)) * Math.Tan((3 * Math.PI) / 10)) / 4;
        }

        public double CalculatePerimeter()
        {
            return (5 * this.side);
        }
    }
}

