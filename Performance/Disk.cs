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
    public class Disk
    {
        public string DiskSerialNo { get; private set; }
        public float DiskSize { get; private set; }
        public float DiskWorkload { get; private set; }
        public float DiskWrite { get; private set; }
        public float DiskRead { get; private set; }

        public Disk()
        {
            DiskSerialNo = getDISKserialno();
            DiskSize = getDISKsize();

            updateValues();
        }
        public void updateValues()
        {
            DiskWorkload = getDISKworkload();
            DiskWrite = getDISKwrite();
            DiskRead = getDISKread();
        }

        public static float getDISKsize()
        {
            throw new NotImplementedException();
            //ToDo: notimplemented
            return 2;
        }
        public static float getDISKworkload()
        {
            PerformanceCounter HDCounter = new PerformanceCounter();
            HDCounter.CategoryName = "Physikalischer Datenträger";
            HDCounter.CounterName = "Zeit (%)";
            HDCounter.InstanceName = "_Total";

            HDCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return HDCounter.NextValue();
        }
        public static float getDISKwrite()
        {
            PerformanceCounter HDCounter = new PerformanceCounter();
            HDCounter.CategoryName = "Physikalischer Datenträger";
            HDCounter.CounterName = "Schreibvorgänge/s";
            HDCounter.InstanceName = "_Total";

            HDCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return HDCounter.NextValue();
        }
        public static float getDISKread()
        {
            PerformanceCounter HDCounter = new PerformanceCounter();
            HDCounter.CategoryName = "Physikalischer Datenträger";
            HDCounter.CounterName = "Lesevorgänge/s";
            HDCounter.InstanceName = "_Total";

            HDCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return HDCounter.NextValue();
        }
        public static string getDISKserialno()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection collection = mangnmt.GetInstances();
            string serialno = "";
            foreach (ManagementObject result in collection)
            {
                serialno += Convert.ToString(result["VolumeSerialNumber"]);
            }
            return serialno;
        }

    }
}
