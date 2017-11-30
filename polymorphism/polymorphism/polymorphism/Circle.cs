using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
            base.Draw();
        }

    }
}
