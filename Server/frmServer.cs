using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using TCPNetwork;
using Encrypt;
using Performance;

namespace Server
{
    public partial class frmServer : Form
    {
        AsyncTcpServer server;

        public frmServer()
        {
            InitializeComponent();

            txtIP.Text = Properties.Settings.Default.IP;
            txtPort.Text = Properties.Settings.Default.Port.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateAdress();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IP != txtIP.Text || Properties.Settings.Default.Port != Convert.ToInt32(txtPort.Text))
            {
                var dialogresult = MessageBox.Show("You haven't save your settings!\nDo you want to discard the changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.No) return;
                else
                {
                    txtIP.Text = Properties.Settings.Default.IP;
                    txtPort.Text = Properties.Settings.Default.Port.ToString();
                }
            }

            if (btnStart.Text == "Start")
            {
                IPAddress address = IPAddress.Parse(txtIP.Text);
                server = new AsyncTcpServer(address, Convert.ToInt32(txtPort.Text));
                server.PacketReceived += Server_PacketReceived;
                server.ClientConnected += Server_ClientConnected;
                server.ClientDisconnected += Server_ClientDisconnected;

                try
                {
                    server.Start();
                    btnStart.Text = "Stop";
                    lblSate.Text = "online";
                    lblSate.ForeColor = Color.Green;

                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    btnSave.Enabled = false;
                }
                catch (Exception ex) //Todo: Spezifische Exeption abrufen
                {
                    MessageBox.Show("Server start failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnStart.Text == "Stop")
            {
                try
                {
                    server.Stop();
                    btnStart.Text = "Start";
                    lblSate.Text = "offline";
                    lblSate.ForeColor = Color.Red;

                    txtIP.Enabled = true;
                    txtPort.Enabled = true;
                    btnSave.Enabled = true;
                }
                catch (Exception ex) //Todo: Spezifische Exeption abrufen
                {
                    MessageBox.Show("Server stop failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool ValidateAdress()
        {
            try
            {
                IPAddress address = IPAddress.Parse(txtIP.Text);
                Properties.Settings.Default.IP = txtIP.Text;
                try
                {
                    Properties.Settings.Default.Port = Convert.ToInt32(txtPort.Text);
                    Properties.Settings.Default.Save();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Bitte gültigen Port eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültige IP-Adresse eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void Server_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            lblClients.Invoke((MethodInvoker)(() => lblClients.Text = $"Clients connected: {server.NumberOfConnectedClients}"));
        }
        private void Server_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            lblClients.Invoke((MethodInvoker)(() => lblClients.Text = $"Clients connected: {server.NumberOfConnectedClients}"));
        }

        private void Server_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            Packet.openPackage(e.Packet);
            string command = "";
            Commands(command, e.Sender);

            //server.SendPacket(new Packet("FAILED")); //ToDo: Broadcast an alle bei einem Fehler
        }

        private void Commands(string command, TcpClient sender)
        {
            switch (command)
            {
                case "getInfos":
                    server.SendPacket(sender, new Packet(new OS()));
                    server.SendPacket(sender, new Packet(new Mainboard()));
                    break;
                case "getCPU":
                    server.SendPacket(sender, new Packet(new CPU()));
                    break;
                case "getRAM":
                    server.SendPacket(sender, new Packet(new RAM()));
                    break;
                case "getMB":
                    server.SendPacket(sender, new Packet(new Mainboard()));
                    break;
                case "getDisk":
                    server.SendPacket(sender, new Packet(new Disk()));
                    break;
            }

        }

    }
}
