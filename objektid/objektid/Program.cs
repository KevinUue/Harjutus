using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog();
            //dog1.RealYears = (7);
            //dog1.Name = "Muki";
            //dog1.Color = "Yellow";

            //Console.WriteLine("Koera nimi: " + dog1.Name);
            //Console.WriteLine("Koera värv: " + dog1.Color);
            //Console.WriteLine("Koera vanus: " + dog1.RealYears);
            //Console.WriteLine("");

            ////Dog dog2 = new Dog();
            ////Console.WriteLine("Sisesta koera nimi: ");
            ////dog2.Name = Console.ReadLine();
            ////Console.WriteLine("Sisesta koera värv: ");
            ////dog2.Color = Console.ReadLine();
            ////Console.WriteLine("Sisesta koera vanus: ");
            ////dog2.Age = int.Parse(Console.ReadLine());

            ////Console.WriteLine("Koera nimi: " + dog2.Name);
            ////Console.WriteLine("Koera värv: " + dog2.Color);
            ////Console.WriteLine("Koera vanus: " + dog2.Age);

            //Dog dog3 = new Dog();
            //Console.WriteLine(dog3.Name);
            //Console.WriteLine(dog3.RealYears);
            //Console.WriteLine(dog3.Color);
            //dog3.Bark();
            //Console.WriteLine("Koeara tegelik vanus on: " + dog3.CalculateDogYears());
            //Console.WriteLine("Koeral on " + dog3.NumberOfEyes + " silma");
            //Console.WriteLine(dog3.IsCarnivore);
            //Console.WriteLine("");

            //Cat cat1 = new Cat();
            //Console.WriteLine("Kassi nimi on: " + cat1.Name);
            //Console.WriteLine("Kassi vanus on: " + cat1.Age);
            //Console.WriteLine("Kassi värv on: " + cat1.Color);
            //cat1.Miau();
            //Console.WriteLine("");

            //Cat cat2 = new Cat();
            //Console.WriteLine("Sisesta kassi nimi: ");
            //cat2.Name = Console.ReadLine();
            //Console.WriteLine("Sisesta kassi vanus: ");
            //cat2.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta kassi värv: ");
            //cat2.Color = Console.ReadLine();

            //Console.WriteLine("Kassi nimi: " + cat2.Name);
            //Console.WriteLine("Kassi vanus: " + cat2.Age);
            //Console.WriteLine("Kassi värv: " + cat2.Color);
            //Console.WriteLine("");

            //Mammal mammal1 = new Mammal();

            Note note1 = new Note();
            Console.WriteLine("Sisestage märkme autor: ");
            note1.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märkmesse märge: ");
            note1.NoteText = Console.ReadLine();
            Console.WriteLine("Sisestage märkme tegemise kuupäev: ");
            note1.ModificationDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Märkme autor: " + note1.Author);
            Console.WriteLine("Märkme sisu: " + note1.NoteText);
            Console.WriteLine("Märkme kuupäev: " + note1.ModificationDate);


            Console.ReadLine();
        }
    }
}
