using System;
using UsesLibrary.IOUses;
using UsesLibrary.Main;
using UsesLibrary.Tests;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
      
            MainUse();

            PaternsUses pu = new PaternsUses();

            pu.ArrowScarf(21,26);


            Read();
        }

        private static void MainUse()
        {
            //init of the Main Uses Class
            var uses = new Uses();


            WriteLn("User Ip Address");
            WriteLn("_______________");
            IoUses.Blank();
            WriteLn(uses.IpUserService.GetIp());
            IoUses.Blank();

            WriteLn("Diagnostics");
            WriteLn("_______________");
            IoUses.Blank();
            WriteLn(uses.CpuUserService.GetCpu());
            WriteLn(uses.CpuUserService.GetRam());
            WriteLn(uses.IpUserService.GetNetworkUsage());
            IoUses.Blank();

        }


        #region Static IO

        public static void WriteLn(string s)
        {
            IoUses.WriteLn(s);
        }

        public static void Write(string s)
        {
            IoUses.Write(s);
        }

        public static void Read()
        {
            Console.Read();
        }

        #endregion
    }
}