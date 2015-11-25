using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voorbeeld2
{
    public class Cursus
    {
        public int Id { get; set; }
        public string Titel { get; set; }

        public string Beschrijving { get; set; }

        public int Moeilijkheid { get; set; }

        public virtual List<Student> Inschrijvingen { get; set; }

    }
}
