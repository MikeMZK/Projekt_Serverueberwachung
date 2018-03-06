using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using Encrypt;
using Performance;

namespace TCPNetwork
{
    public class Packet
    {
        public byte[] data { get; private set; }

        private List<byte> templst = new List<byte>();

        private static byte STARTMESSAGE = 200;
        private static byte ENDMESSAGE = 201;
        private static byte STARTHASH = 220;
        private static byte ENDHASH = 221;

        private static byte FLAG = 255;
        private enum DATATYPE : byte { STRING = 110, DOUBLE = 115, INT = 120, CPU = 130, RAM = 135, DISK = 140, OS = 145, NETWORK = 150, MAINBOARD = 155 };

        public Packet(int message)
        {
            setInt(message);
            setStartFlag();
            setEndFlag();

            data = completePackage();
        }
        public Packet(double message)
        {
            setDouble(message);
            setStartFlag();
            setEndFlag();

            data = completePackage();
        }
        public Packet(string message)
        {
            setString(message);
            setStartFlag();
            setEndFlag();

            data = completePackage();
        }
        public Packet(object message)
        {
            setObject(message);
            setStartFlag();
            setEndFlag();

            data = completePackage();
        }

        #region Create package
        private void setStartFlag() => templst.Insert(0, FLAG);
        private void setEndFlag() => templst.Insert(templst.Count, FLAG);

        private void setInt(int message)
        {
            byte[] bytes = new byte[1];
            bytes[0] = Convert.ToByte(message);

            templst = packMessage(bytes).ToList();

            templst.Insert(0, (byte)DATATYPE.INT);
        }
        private void setDouble(double message)
        {
            byte[] bytes = new byte[1];
            bytes[0] = Convert.ToByte(message);

            templst = packMessage(bytes).ToList();

            templst.Insert(0, (byte)DATATYPE.DOUBLE);
        }
        private void setString(string message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(message);

            templst = packMessage(bytes).ToList();

            templst.Insert(0, (byte)DATATYPE.STRING);
        }
        private void setObject(object message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(message));

            templst = packMessage(bytes).ToList();

            switch (message.GetType().Name)
            {
                case "CPU":
                    templst.Insert(0, (byte)DATATYPE.CPU);
                    break;
                case "OS":
                    templst.Insert(0, (byte)DATATYPE.OS);
                    break;
                case "Disk":
                    templst.Insert(0, (byte)DATATYPE.DISK);
                    break;
                case "Network":
                    templst.Insert(0, (byte)DATATYPE.NETWORK);
                    break;
                case "RAM":
                    templst.Insert(0, (byte)DATATYPE.RAM);
                    break;
                case "Mainboard":
                    templst.Insert(0, (byte)DATATYPE.MAINBOARD);
                    break;
            }
        }

        private byte[] completePackage()
        {
            return Rijndael.Encrypt(templst.ToArray());
            //return templst.ToArray();
        }

        #endregion

        #region Open package

        public static object openPackage(byte[] package)
        {
            package = Rijndael.Decrypt(package);

            byte[] packetdata;

            if (package[0] != 255 || package[package.Length - 1] != 255)
            {
                throw new NotImplementedException();
            }

            packetdata = trimMessage(package);

            switch (package[1])
            {
                case (byte)DATATYPE.INT:
                    byte tmp = packetdata[0];
                    return Convert.ToInt32(tmp);
                case (byte)DATATYPE.DOUBLE:
                    tmp = packetdata[0];
                    return Convert.ToDouble(tmp);
                case (byte)DATATYPE.STRING:
                    return Encoding.ASCII.GetString(packetdata);
                case (byte)DATATYPE.CPU:
                    return JsonConvert.DeserializeObject<CPU>(Encoding.ASCII.GetString(packetdata));
                case (byte)DATATYPE.OS:
                    return JsonConvert.DeserializeObject<OS>(Encoding.ASCII.GetString(packetdata));
                case (byte)DATATYPE.DISK:
                    return JsonConvert.DeserializeObject<Disk>(Encoding.ASCII.GetString(packetdata));
                case (byte)DATATYPE.NETWORK:
                    throw new NotImplementedException();
                //ToDo: NotImplemented
                case (byte)DATATYPE.RAM:
                    return JsonConvert.DeserializeObject<RAM>(Encoding.ASCII.GetString(packetdata));
                case (byte)DATATYPE.MAINBOARD:
                    return JsonConvert.DeserializeObject<Mainboard>(Encoding.ASCII.GetString(packetdata));
            }
            return null;
        }

        #endregion

        #region Datenüberprüfung (durch md5)

        private static byte[] trimMessage(byte[] packet)
        {
            List<byte> datas = new List<byte>();//Steht nachher nur der ungehashte Tein drin
            List<byte> hashwert = new List<byte>();//steht nachher nur der Gehashte Teil drin
            int i;
            for (i = 0; packet[i] != STARTMESSAGE; i++) ;
            for (i++; packet[i] != ENDMESSAGE; i++)
            {
                datas.Add(packet[i]);
            }
            for (i = i + 2; packet[i] != ENDHASH; i++)
            {
                hashwert.Add(packet[i]);
            }

            if (IsCorrectSend(datas.ToArray(), hashwert.ToArray())) return datas.ToArray();
            throw new Exception(); //Wenn das Packet fehlerhaft ist
        }
        private static byte[] packMessage(byte[] unhashedByte)
        {
            byte[] hashedByte = md5.encrypt(unhashedByte);
            List<byte> FullByte = new List<byte>();

            FullByte.Add(STARTMESSAGE);
            foreach (byte temp in unhashedByte)
            {
                FullByte.Add(temp);
            }
            FullByte.Add(ENDMESSAGE);
            FullByte.Add(STARTHASH);
            foreach (byte temp in hashedByte)
            {
                FullByte.Add(temp);
            }
            FullByte.Add(ENDHASH);
            return FullByte.ToArray();
        }

        private static bool IsCorrectSend(byte[] unhashed, byte[] hashed)
        {
            byte[] data = md5.encrypt(unhashed);
            if (hashed.SequenceEqual(data)) return true;
            else return false;
        }

        #endregion

    }
}
