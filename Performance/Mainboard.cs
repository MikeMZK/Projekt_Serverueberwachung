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
    public class Mainboard
    {
        public static string getMAINBOARDmaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("Manufacturer").ToString();
            }
            return "Board Maker: Unknown";
        }
        public static string getMAINBOARDid()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("Product").ToString();
            }
            return "Product: Unknown";
        }
        public static string getBIOSmaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("Manufacturer").ToString();
            }
            return "BIOS Maker: Unknown";
        }
        public static string getBIOSserialno()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("SerialNumber").ToString();
            }
            return "BIOS Serial Number: Unknown";
        }
        public static string getBIOScaption()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

            foreach (ManagementObject result in searcher.Get())
            {
                return result.GetPropertyValue("Caption").ToString();
            }
            return "BIOS Caption: Unknown";
        }
        public static string getMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection collection = mc.GetInstances();
            string MACAddress = "";
            foreach (ManagementObject result in collection)
            {
                if (MACAddress == String.Empty)
                {
                    if ((bool)result["IPEnabled"] == true) MACAddress = result["MacAddress"].ToString();
                }
                result.Dispose();
            }
            return MACAddress;
        }
        

    }
}
