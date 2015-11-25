using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework01
{
   public class Properties
    {
       public int Id { get; set; }
       public string  Name { get; set; }
       public String Email { get; set; }


       public override string ToString()
       {
           return Name + "  " + Email;
       }
    }
}
