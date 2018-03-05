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
using TCPNetwork;
using Encrypt;
using Performance;

namespace Client
{
    public partial class frmClient : Form
    {
        IPAddress address;
        int port;

        public frmClient()
        {
            InitializeComponent();

            cpbRAM.SendToBack();
            cpbCPU.SendToBack();
            cpbNetwork.SendToBack();
            cpbDisk.SendToBack();

            txtIP.Text = Properties.Settings.Default.IP;
            txtPort.Text = Properties.Settings.Default.Port.ToString();
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


        }

        private void tpPerformance_Enter(object sender, EventArgs e)
        {
            cpbCPU.BringToFront();
            cpbNetwork.BringToFront();
            cpbDisk.BringToFront();
            cpbRAM.BringToFront();
        }
        private void tpPerformance_Leave(object sender, EventArgs e)
        {
            cpbRAM.SendToBack();
            cpbCPU.SendToBack();
            cpbNetwork.SendToBack();
            cpbDisk.SendToBack();
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
    }
}
