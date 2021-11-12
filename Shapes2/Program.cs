using System;

namespace Shapes2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Circ = new Circle(100);
            Console.WriteLine("Circle with radius 100\n");
            Console.WriteLine("Area is {0}\n", Circ.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Circ.CalculatePerimeter());


            var Rect = new Rectangle(20, 10);
            Console.WriteLine("Rectangle with sides of 20 and 10\n");
            Console.WriteLine("Area is {0}\n", Rect.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Rect.CalculatePerimeter());
            

            var Sq = new Square(4);
            Console.WriteLine("Square with sides of 4\n");
            Console.WriteLine("Area is {0}\n", Sq.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Sq.CalculatePerimeter());

            var Eps = new Ellipse(4, 10);
            Console.WriteLine("Ellipse of minor axis 4 and major axis 10\n");
            Console.WriteLine("Area is {0}\n", Eps.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Eps.CalculatePerimeter());

            var Pent = new Pentagon(8);
            Console.WriteLine("Equillateral pentagon of sides 8\n");
            Console.WriteLine("Area is {0}\n", Pent.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Pent.CalculatePerimeter());

        }
    }
}
