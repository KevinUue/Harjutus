using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektid
{
    class Dog : Mammal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int RealYears { get; set; }

        public Dog()
        {
            Name = "Rex";
            Age = 4;
            Color = "Brown";
            CalculateDogYears();
        }

        public void Bark()
        {
            Console.WriteLine("Auh Auh!!!");
        }

        public int CalculateDogYears()
        {
            RealYears = Age * 7;
            return RealYears;
        }


    }
}
