using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class abstraction
    {
        public abstract double CalculateArea();
        public abstract void Draw();
    }

    // Concrete classes representing specific shapes
    public class Circle : abstraction
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }
    }

    public class Rectangle : abstraction
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
        }
    }

   /* public class Program
    {
        static void Main()
        {
            abstraction circle = new Circle(5.0);
            abstraction rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            circle.Draw();

            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            rectangle.Draw();
        }
    }*/

}

