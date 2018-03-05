using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    public sealed class Network
    {
        #region Singleton Pattern
        public Network() { }
        private static volatile Network instance = null;
        public static Network getInstance()
        {
            // DoubleLock
            if (instance == null)
                lock (m_lock)
                {
                    if (instance == null)
                        instance = new Network();
                }
            return instance;
        }

        // Hilfsfeld für eine sichere Threadsynchronisierung
        private static object m_lock = new object();

        #endregion

        #region Instanz Variablen - interfaceStats, _NicArr, _BytesReceived, _BytesSent
        private IPv4InterfaceStatistics interfaceStats = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();
        private NetworkInterface[] _nicArr;
        private int _BytesReceived;
        private int _BytesSent;
        #endregion

        #region Instanz Methode - getInterfaces, getSentSpeed, getReceivedSpeed
        /// <summary>
        /// Initaliziert alle verfügbaren Network Interfaces am Computer und gibt
        /// diese als NetworkInterface[] zurück.
        /// </summary>
        /// <returns>Alle verfügbaren Network Interfaces</returns>
        public NetworkInterface[] getInterfaces()
        {
            NetworkInterface[] tArr;
            tArr = NetworkInterface.GetAllNetworkInterfaces();
            return tArr;
        }

        /// <summary>
        /// Gibt das Network Interface "Local Area Connection" zurück
        /// </summary>
        /// <returns></returns>
        public NetworkInterface getLocalAreaConnection()
        {
            // Alle Interfaces zum InterfaceArray hinzufügen
            _nicArr = getInterfaces();

            // Deklarieren des Interfaces
            NetworkInterface nic = _nicArr[0];

            // Es wird nun ausgelesen, ob eine "Local Area Connection" vorhanden ist
            // diese wird dann ausgewählt
            foreach (NetworkInterface tNic in _nicArr)
            {
                if (tNic.Name.Contains("Local Area Connection"))
                    nic = tNic; // deklarieren der lokalen Verbindung (LAN)
            }
            return nic;
        }

        /// <summary>
        /// Diese Methode gibt den Received Speed (Download) zurück
        /// </summary>
        /// <param name="nic">NetworkInterface auf welchenm der Speed gemessen werden soll</param>
        /// <returns>Download in KB/s</returns>
        public int getReceivedSpeed(NetworkInterface nic)
        {
            // Neue IPv4 Interface Statistik erstellen
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            // Definieren des Empfangenen Speeds im KB/s
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - _BytesReceived) / 1024;

            // Deklarieren der globalen Variablen
            _BytesReceived = (int)interfaceStats.BytesReceived; // empfangenen Bytes

            // Rückgabe des Wertes
            return bytesReceivedSpeed;
        }

        /// <summary>
        /// Dieses Methode gibt den Sent Speed (Upload) zurück
        /// </summary>
        /// <param name="nic">NetworkInterface auf welchem der Speed gemessen werden soll</param>
        /// <returns>Upload in KB/s</returns>
        public int getSentSpeed(NetworkInterface nic)
        {
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            // Berechnen des ausgehenden (Upload) Speeds für das Interaface (in KB/s)
            int bytesSentSpeed = (int)(interfaceStats.BytesSent - _BytesSent) / 1024;

            // Deklarieren der globalen Variablen
            _BytesSent = (int)interfaceStats.BytesSent; // gesendete Bytes

            // Rückgabe des Werts
            return bytesSentSpeed;
        }
        #endregion


    }
}
