using UsesLibrary.CPUUses;
using UsesLibrary.IpUses;

namespace UsesLibrary.Main
{
    public class Uses
    {
        
        public IpUser IpUserService { get; set; }
        public CpuUser CpuUserService { get; set; }
        public Uses()
        {
            IpUserService = new IpUser();
            CpuUserService = new CpuUser();
        }
    }
}
