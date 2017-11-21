using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Program
    {
        static void Main(string[] args)
        {
            note note1 = new note();
            Console.WriteLine("Sisestage oma nimi: ");
            note1.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge: ");
            note1.NoteText = Console.ReadLine();
            note1.ModificationDate = DateTime.Now;

            //Console.WriteLine("Teie nimi: " + note1.Author);
            //Console.WriteLine("Teie märge: " + note1.NoteText);
            //Console.WriteLine("Muutmiskuupäev: " + note1.ModificationDate);

            note note2 = new note();
            Console.WriteLine("Sisestage oma nimi: ");
            note2.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge: ");
            note2.NoteText = Console.ReadLine();
            note2.ModificationDate = DateTime.Now;

            List<note> NoteList = new List<note>();
            NoteList.Add(note1);
            NoteList.Add(note2);

            foreach(note element in NoteList)
            {
                Console.WriteLine("Teie nimi: " + element.Author);
                Console.WriteLine("Teie märge: " + element.NoteText);
                Console.WriteLine("Muutmiskuupäev: " + element.ModificationDate);

            }

            
            Console.ReadLine();

        }
    }
}
