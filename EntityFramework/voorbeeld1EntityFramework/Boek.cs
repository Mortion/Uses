using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeld1EntityFramework
{
   public class Boek
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string ISBNNummer { get; set; }
        public int Jaartal { get; set; }
    }
}
