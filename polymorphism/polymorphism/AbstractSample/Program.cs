using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            Console.WriteLine("Ruudu pindala on: " + square.Area());


            Console.ReadLine();

        }
    }
}
