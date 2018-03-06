using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using TCPNetwork;
using Encrypt;
using Performance;
using Diagramm;

namespace Client
{
    public partial class frmClient : Form
    {
        AsyncTcpClient client;
        Thread performancetimer;
        IPAddress address;
        int port;

        public frmClient()
        {
            InitializeComponent();

            client = new AsyncTcpClient();
            client.PacketReceived += Client_PacketReceived;


            this.Width = 535;
            this.Height = 230;

            cpbRAM.SendToBack();
            cpbCPU.SendToBack();
            cpbNetwork.SendToBack();
            cpbDisk.SendToBack();

            txtIP.Text = Properties.Settings.Default.IP;
            txtPort.Text = Properties.Settings.Default.Port.ToString();
        }

        private void Client_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            var obj = Packet.openPackage(e.Packet);
            useObj(obj);
            //if (package == "FAILED") MessageBox.Show("Server overloaded");     //Broadcast meldung bei einem Fehler

        }

        private void useObj(object obj)
        {
            switch (obj.GetType().Name)
            {
                case "OS":
                    OS os = (OS)obj;
                    lblComputerName.Invoke((MethodInvoker)(() => lblComputerName.Text = $"Computer Name: {os.ComputerName}"));
                    lblAccountName.Invoke((MethodInvoker)(() => lblAccountName.Text = $"Account Name: {os.AccountName}"));
                    lblLanguage.Invoke((MethodInvoker)(() => lblLanguage.Text = $"Language: {os.Language}"));
                    lblOS.Invoke((MethodInvoker)(() => lblOS.Text = $"OS: {os.OSInformation}"));
                    break;
                case "Mainboard":
                    Mainboard mb = (Mainboard)obj;
                    lblMainboard.Invoke((MethodInvoker)(() => lblMainboard.Text = $"Mainboard: {mb.MainboardMaker} {mb.MainboardID}"));
                    lblBios.Invoke((MethodInvoker)(() => lblBios.Text = $"Bios: {mb.BiosMaker} {mb.BiosCaption} {mb.BiosSerialNo}"));
                    lblMacAddress.Invoke((MethodInvoker)(() => lblMacAddress.Text = $"MacAddress: {mb.MacAddress}"));
                    break;
                case "CPU":
                    CPU cpu = (CPU)obj;
                    cpbCPU.Invoke((MethodInvoker)(() => cpbCPU.Value = Convert.ToInt32(cpu.CPUworkload)));
                    break;
                case "RAM":
                    RAM ram = (RAM)obj;
                    cpbRAM.Invoke((MethodInvoker)(() => cpbRAM.Maximum = Convert.ToInt32(ram.RAMsize * 1000)));
                    cpbRAM.Invoke((MethodInvoker)(() => cpbRAM.Value = Convert.ToInt32(ram.RAMavailable)));
                    break;
                case "Disk":
                    Disk disk = (Disk)obj;
                    cpbDisk.Invoke((MethodInvoker)(() => cpbDisk.Value = Convert.ToInt32(disk.DiskWorkload)));
                    break;
            }

        }

        private bool ValidateAdress()
        {
            try
            {
                address = IPAddress.Parse(txtIP.Text);
                Properties.Settings.Default.IP = txtIP.Text;
                try
                {
                    port = Properties.Settings.Default.Port = Convert.ToInt32(txtPort.Text);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateAdress()) return;

            if (txtUsername.Text != "Admin" || txtPassword.Text != "admin") return; //Login Abfrage

            this.Width = 500;
            this.Height = 250;

            gbLogin.Visible = false;
            gbProperties.Visible = false;
            btnLogin.Visible = false;
            tcMain.Visible = true;

            client.Connect(address, port);

            client.SendPacket(new Packet("getInfos"));
        }

        private void tpPerformance_Enter(object sender, EventArgs e)
        {
            this.Width = 810;
            this.Height = 720;

            cpbCPU.Visible = true;
            cpbNetwork.Visible = true;
            cpbDisk.Visible = true;
            cpbRAM.Visible = true;

            cpbCPU.BringToFront();
            cpbNetwork.BringToFront();
            cpbDisk.BringToFront();
            cpbRAM.BringToFront();

            performancetimer = new Thread(generalPerformance);
            performancetimer.IsBackground = true;
            performancetimer.Start();

        }
        private void tpPerformance_Leave(object sender, EventArgs e)
        {
            cpbCPU.Visible = true;
            cpbNetwork.Visible = true;
            cpbDisk.Visible = true;
            cpbRAM.Visible = true;

            cpbRAM.SendToBack();
            cpbCPU.SendToBack();
            cpbNetwork.SendToBack();
            cpbDisk.SendToBack();

            //performancetimer.Suspend();
        }

        private void generalPerformance()
        {
            while (true)
            {
                client.SendPacket(new Packet("getCPU"));
                client.SendPacket(new Packet("getRAM"));
                client.SendPacket(new Packet("getMB"));
                client.SendPacket(new Packet("getDisk"));

                Thread.Sleep(1000);
            }
        }

        private void cpbCPU_Click(object sender, EventArgs e)
        {
            tbcPerfMenu.SelectedTab = tabCPU;
            cpbCPU.BackColor = Color.Gray;
            cpbDisk.BackColor = Color.Transparent;
            cpbRAM.BackColor = Color.Transparent;
            cpbNetwork.BackColor = Color.Transparent;
        }
        private void cpbDisk_Click(object sender, EventArgs e)
        {
            tbcPerfMenu.SelectedTab = tabDisk;
            cpbDisk.BackColor = Color.Gray;
            cpbCPU.BackColor = Color.Transparent;
            cpbRAM.BackColor = Color.Transparent;
            cpbNetwork.BackColor = Color.Transparent;
        }
        private void cpbRAM_Click(object sender, EventArgs e)
        {
            tbcPerfMenu.SelectedTab = tabRAM;
            cpbRAM.BackColor = Color.Gray;
            cpbDisk.BackColor = Color.Transparent;
            cpbCPU.BackColor = Color.Transparent;
            cpbNetwork.BackColor = Color.Transparent;
        }
        private void cpbNetwork_Click(object sender, EventArgs e)
        {
            tbcPerfMenu.SelectedTab = tbNetwork;
            cpbNetwork.BackColor = Color.Gray;
            cpbDisk.BackColor = Color.Transparent;
            cpbRAM.BackColor = Color.Transparent;
            cpbCPU.BackColor = Color.Transparent;
        }

        private void tpInformation_Enter(object sender, EventArgs e)
        {


            this.Width = 500;
            this.Height = 200;
        }

    }
}
