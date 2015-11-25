using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voorbeeld2
{
    public class Student
    {
        public Student()
        {
            IngeschrevenCursussen = new List<Cursus>();
        }

        public int StudentId { get; set; }
        public string Naam { get; set; }

        public string Email { get; set; }

        public string Gsm { get; set; }

        public virtual List<Cursus> IngeschrevenCursussen { get; set; }
    }
}
