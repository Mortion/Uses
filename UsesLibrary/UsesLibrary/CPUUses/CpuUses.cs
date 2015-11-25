using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.CPUUses
{
    internal class CpuUses
    {
        private PerformanceCounter _cpuCounter;
        private PerformanceCounter _ramCounter;

        public CpuUses()
        {
            InitialiseCpuCounter();
            InitializeRamCounter();
        }

        private void InitialiseCpuCounter()
        {
            _cpuCounter = new PerformanceCounter(
            "Processor",
            "% Processor Time",
            "_Total",
            true
            );
        }

        private void InitializeRamCounter()
        {
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

        }

        public string GetRamCount()
        {
            return Convert.ToInt32(_ramCounter.NextValue()).ToString() + "Mb";
        }

        public string GetCpu()
        {
            return "CPU Usage: " +
            Convert.ToInt32(_cpuCounter.NextValue()).ToString() +
            "%";
        }

    }
}
