using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student()
            {
                Naam = "Jansens Peter",
                Email = "p.jansens@gmail.com",
                Gsm = "0473/45.45.45"

            };

            Cursus cursus = new Cursus()
            {
                Titel = "Programmeren 3",
                Beschrijving = "Databases aanspreken in .net",
                Moeilijkheid = 2
            };

            s.IngeschrevenCursussen.Add(cursus);

            using (var context = new SchoolContext())
            { 
                context.Cursussen.Add(cursus);
                context.Studenten.Add(s);
               
                context.SaveChanges();
            }

            using (var context = new SchoolContext())
            {
                foreach (var student in context.Studenten)
                {
                    Console.WriteLine(student.Naam);
                    Console.WriteLine(student.Email);

                    foreach (var c in student.IngeschrevenCursussen)
                    {
                        Console.WriteLine(c.Titel);
                    }
                    Console.WriteLine("---------------------");
                }

            }
            Console.ReadLine();

        }
    }
}
