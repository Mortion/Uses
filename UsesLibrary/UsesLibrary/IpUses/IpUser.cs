using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.IpUses
{
    public class IpUser : IUsesIp
    {
       private IpUses uses;

        public IpUser()
        {
            uses = new IpUses();
        }

        public string GetIp()
        {
            return uses.GetIp();
        }

        public bool CompareIp()
        {
            return uses.CompareIp();
        }

        public string GetNetworkUsage()
        {
            return uses.GetNetworkUsage();
        }
    }
}
