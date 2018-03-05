using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace WinClient
{
    public class OS
    {


        public static string getCOMPUTERname()
        {
            string name = "";
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection collection = mc.GetInstances();
            foreach (ManagementObject result in collection)
            {
                name = (string)result["Name"];
            }
            return name;
        }
        public static string getACCOUNTname()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("Name").ToString();
            }
            return "User Account Name: Unknown";
        }
        public static string getLANGUAGE()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("CurrentLanguage").ToString();
            }
            return "Language: Unknown";
        }
        public static string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
            }
            return "Failed";
        }

    }
}