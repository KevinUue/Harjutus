﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektid
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Cat()
        {
            Name = "Kiisu";
            Age =3;
            Color = "Brown";
            
        }

        public void Miau()
        {
            Console.WriteLine("Miäu miäu!");
        }

    }
}
