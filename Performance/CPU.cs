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
    public class CPU
    {
        public string CPUname { get; private set; }
        public float CPUworkload { get; private set; }
        public List<int> CPUcores { get; private set; }

        public CPU()
        {
            CPUname = getCPUname();

            updateValues();
        }
        public void updateValues()
        {
            CPUworkload = getCPUworkload();
            CPUcores = getCPUcores();
        }

        public static float getCPUworkload()
        {
            PerformanceCounter CPUCounter = new PerformanceCounter();
            CPUCounter.CategoryName = "Prozessor";
            CPUCounter.CounterName = "Prozessorzeit (%)";
            CPUCounter.InstanceName = "_Total";

            CPUCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return CPUCounter.NextValue();
        }
        public static List<int> getCPUcores()
        {
            List<int> cores = new List<int>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
            foreach (ManagementObject result in searcher.Get())
            {
                string name = result["name"].ToString();
                if (name != "_Total") cores.Add(Convert.ToInt32(result["PercentProcessorTime"]));
            }
            return cores;
        }
        public static string getCPUname()
        {
            string name = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject result in searcher.Get())
            {
                name = result["Name"].ToString();
            }

            return name;
        }

    }
}
