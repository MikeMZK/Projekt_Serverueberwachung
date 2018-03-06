using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Log
{
    public class LogWrite
    {
        public void WriteLog(string datas)
        {
            if (!File.Exists("networklog.txt")) File.Create("networklog.txt");
            string[] readText = File.ReadAllLines("networklog.txt");
            int anzahl = readText.Length;
            DateTime now = DateTime.Now;
            string timestamp = now.ToString();

            var newArray = new string[readText.Length];
            newArray = readText;

            if (anzahl >= 150)
            {
                Array.Copy(readText, 1, newArray, 0, readText.Length - 1);
                newArray[readText.Length - 1] = (timestamp + "//  " + datas);
                File.WriteAllLines("networklog.txt", newArray);
            }
            else
            {
                StreamWriter sw = new StreamWriter("networklog.txt", true, Encoding.UTF8);
                sw.WriteLine((timestamp + "//  " + datas));
                sw.Close();
            }
            //  StreamWriter sw = new StreamWriter("log.txt",false,Encoding.UTF8);
            //  sw.Close();
        }
        public void TxtClients(string ipAdress)
        {
            if (!File.Exists("userlog.txt")) File.Create("userlog.txt");
            string[] readText = File.ReadAllLines("userlog.txt");
            int anzahl = readText.Length;
            DateTime now = DateTime.Now;
            string timestamp = now.ToString();

            var newArray = new string[readText.Length];
            newArray = readText;

            if (anzahl >= 150)
            {
                Array.Copy(readText, 1, newArray, 0, readText.Length - 1);
                newArray[readText.Length - 1] = (timestamp + "//  " + ipAdress);
                File.WriteAllLines("userlog.txt", newArray);
            }
            else
            {
                StreamWriter sw = new StreamWriter("userlog.txt", true, Encoding.UTF8);
                sw.WriteLine((timestamp + "//  " + ipAdress));
                sw.Close();
            }

        }
    }
}
