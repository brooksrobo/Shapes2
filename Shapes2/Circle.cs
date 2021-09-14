using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{


    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            Console.WriteLine(String.Format("I'm initializing a new Circle instance with a radius value of {0}.", radius));
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
