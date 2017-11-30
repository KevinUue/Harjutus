using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc1 = new Calculation();
            calc1.test();
            var calc2 = new Calculation();
            calc2.test();
            var calc3 = new Calculation();
            calc3.test();


            Console.ReadLine();
        }
    }
}
