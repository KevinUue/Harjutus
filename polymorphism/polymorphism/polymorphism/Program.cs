using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new Shape();
            shape1.X = 10;
            shape1.Y = 20;
            shape1.Height = 50;
            shape1.Width = 100;
            //shape1.Draw();

            var circle1 = new Circle();
            circle1.X = 10;
            circle1.Y = 20;
            circle1.Height = 50;
            circle1.Width = 80;
            //circle1.Draw();

            var rectangle1 = new Rectangle();
            rectangle1.X = 10;
            rectangle1.Y = 20;
            rectangle1.Height = 40;
            rectangle1.Width = 80;
            //rectangle1.Draw();

            var triangle1 = new Triangle();
            triangle1.X = 20;
            triangle1.Y = 40;
            triangle1.Height = 80;
            triangle1.Width = 160;
            //triangle1.Draw();

            var shapes = new List<Shape>();
            shapes.Add(shape1);
            shapes.Add(circle1);
            shapes.Add(rectangle1);
            shapes.Add(triangle1);

            foreach (var i in shapes)
            {
                i.Draw();
            }



            
            Console.ReadLine();
        }
    }
}
