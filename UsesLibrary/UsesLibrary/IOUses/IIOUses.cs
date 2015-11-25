using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.IOUses
{
    internal interface IIoUses
    {
        void WriteLn(string s);
        void Write(string s);
        void Blank();
    }
}
