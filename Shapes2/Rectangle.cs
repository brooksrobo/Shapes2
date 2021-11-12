using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{

    class Rectangle : Shape
    {
        private double width { get; set; }
        private double height { get; set; }

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
            return height * width;
        }

        public static double CalculatePerimeter(double height, double width)
        {
            return (2 * height) + (2 * width);
        }

        private double CalculatePerimeter()
        {
            return (this.height * 2) + (this.width * 2);
        }

        public static Rectangle operator >(Rectangle r, Rectangle t)
        {
            double temp1 = r.width * r.height;
            double temp2 = t.width * t.height;

            if (temp1 > temp2)
            {
                return r;
            }
            else
            {
                return t;
            }
        }
        public static Rectangle operator <(Rectangle r, Rectangle t)
        {
            double temp1 = r.width * r.height;
            double temp2 = t.width * t.height;

            if (temp1 < temp2)
            {
                return r;
            }
            else
            {
                return t;
            }
        }

        public override bool Equals(object obj)
        {

            if (((Rectangle)obj).width == this.width && ((Rectangle)obj).height == this.height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator == (Rectangle r, Rectangle t)
        {
            return r.Equals(t);
        }
        public static bool operator != (Rectangle r, Rectangle t)
        {
            return ! r.Equals(t);
        }

        public static Rectangle operator >= (Rectangle r, Rectangle t)
        {
            double temp1 = r.width * r.height;
            double temp2 = t.width * t.height;

            if (temp1 >= temp2)
            {
                return r;
            }
            else
            {
                return t;
            }
        }

        public static Rectangle operator <= (Rectangle r, Rectangle t)
        {
            double temp1 = r.width * r.height;
            double temp2 = t.width * t.height;

            if (temp1 <= temp2)
            {
                return r;
            }
            else
            {
                return t;
            }
        }


    }
}
