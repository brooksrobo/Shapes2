using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{

    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle()
        {
            this.height = 0;
            this.width = 0;
        }

        public Rectangle(Rectangle r)
        {
            height = r.height;
            width = r.width;
        }
        public Rectangle(double width, double height)
        {
           // Console.WriteLine(String.Format("I'm initializing a new rectangle instance with a width value of {0} and a height value of {1}.", width, height));
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return this.width * this.height;
        }

        public double CalculatePerimeter()
        {
            return (2 * this.width) + (2 * this.height);
        }
    }
}
