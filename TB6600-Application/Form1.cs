using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TB6600_Application
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {

        }

        private void UpButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
        }

        private void SetPosition_Click(object sender, EventArgs e)
        {

        }

        private void COMPortComboBox_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COMPortComboBox.Items.Clear();
            COMPortComboBox.Items.AddRange(ports);
        }
    }
}
