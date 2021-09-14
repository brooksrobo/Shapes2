using System;

namespace Shapes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Cone = new Circle(60);
            Console.WriteLine("Area is {0}\n", Cone.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Cone.CalculatePerimeter());


            var Rect = new Rectangle(20, 10);
            Console.WriteLine("Area is {0}\n", Rect.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Rect.CalculatePerimeter());

            var Sq = new Square(4);
            Console.WriteLine("Area is {0}\n", Sq.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Sq.CalculatePerimeter());

            var Eps = new Ellipse(4, 10);
            Console.WriteLine("Area is {0}\n", Eps.CalculateArea());
            Console.WriteLine("Perimeter is {0}\n", Eps.CalculatePerimeter());

        }
    }
}
