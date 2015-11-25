using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuchthavenLibrary
{
    public interface IMovement
    {
        String Location { get; set; }

         void ChangeLocation();
    }
}
