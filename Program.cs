using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.LENGTH = 5;
            r.WIDTH = 6;
            Console.WriteLine($"The Area of The Rectagle is {r.calculateArea()}");

            Circle c = new Circle();
            c.RADIUS = 7;

            Console.WriteLine($"\nThe Area of The Circle is {c.calculateArea()}");
            Console.WriteLine($"\nThe Perimeter of The Circle is {c.calculatePerimeter()}");
        }
    }

    abstract class Shape
    {
        public abstract double calculateArea();

        public abstract double calculatePerimeter();
    }

    class Rectangle : Shape
    {
        private double length, width;
        // property
        public double LENGTH
        {
            set { length = value; }
            get { return length; }
        }

        public double WIDTH
        {
            set { width = value; }
            get { return width; }
        }


        public override double calculateArea()
        {
            return length * width;
        }

        public override double calculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }


    class Circle : Shape
    {
        static double pi = 3.14159265359;

        private double radius;
          public double RADIUS
          {
            set { radius = value; }
            get { return radius; }
          }


        public override double calculateArea()
        {
            return (pi * (radius * radius));
        }

        public override double calculatePerimeter()
        {
            return (2 * (pi) * (radius));
        }
    }
}
