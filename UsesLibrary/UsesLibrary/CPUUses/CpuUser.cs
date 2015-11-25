using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.CPUUses
{
    public class CpuUser
    {
        private CpuUses uses;
        public CpuUser()
        {
            uses = new CpuUses();
        }

        public string GetCpu()
        {
            return uses.GetCpu();
        }

        public string GetRam()
        {
            return uses.GetRamCount();
        }
    }
}
