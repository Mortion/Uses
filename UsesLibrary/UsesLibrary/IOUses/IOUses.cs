using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.IOUses
{
    public static class IoUses 
    {
        public static void WriteLn(string s)
        {
            Console.WriteLine(s);
        }

        public static void Write(string s)
        {
            Console.Write(s);
        }

        public static void Blank()
        {
            WriteLn("");
        }
    }
}
