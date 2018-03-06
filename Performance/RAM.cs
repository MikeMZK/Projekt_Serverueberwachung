using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace Performance
{
    public class RAM
    {
        public float RAMavailable { get; private set; }
        public double RAMsize { get; private set; }

        public RAM()
        {
            updateValues();
        }
        public void updateValues()
        {
            RAMavailable = getRAMavailable();
            RAMsize = getRAMsize();
        }


        public static float getRAMavailable()
        {
            PerformanceCounter RAMCounter = new PerformanceCounter();
            RAMCounter.CategoryName = "Memory";
            RAMCounter.CounterName = "Available MBytes";

            RAMCounter.NextValue();
            System.Threading.Thread.Sleep(100);
            return RAMCounter.NextValue();
        }
        public static double getRAMsize()
        {
            double res = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject result in searcher.Get())
            {
                res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
            }
            return Math.Round((res / (1024 * 1024)), 2);
        }

    }
}
