using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    class Ellipse
    {
        private double minoraxis;
        private double majoraxis;

        public Ellipse()
        {
            this.majoraxis = 0;
            this.minoraxis = 0;
        }

        public Ellipse(Ellipse e)
        {
            majoraxis = e.majoraxis;
            minoraxis = e.minoraxis;
        }
        public Ellipse(double minoraxis, double majoraxis)
        {
            Console.WriteLine(String.Format("I'm initializing a new ellipse instance with a minor axis value of {0} and a major axis value of {1}.", minoraxis, majoraxis));
            this.minoraxis = minoraxis;
            this.majoraxis = majoraxis;
        }

        public double CalculateArea()
        {
            return Math.PI * this.minoraxis * this.majoraxis;
        }

        public double CalculatePerimeter()
        {
            return Math.PI * (3 * (this.majoraxis + this.minoraxis) - Math.Sqrt((3 * this.majoraxis + this.minoraxis) * (this.majoraxis + 3*(this.minoraxis))));
        }
    }
}
