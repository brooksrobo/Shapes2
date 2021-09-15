using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    class Square
    {
        private double side;

        public Square()
        {
            this.side = 0;
        }

        public Square(Square s)
        {
            side = s.side;
        }
        public Square(double side)
        {
            Console.WriteLine(String.Format("I'm initializing a new square instance with a side length of {0}.", side));
            this.side = side;
        }

        public double CalculateArea()
        {
            return Math.Pow(this.side, this.side);
        }

        public double CalculatePerimeter()
        {
            return (4 * this.side);
        }
    }
}
