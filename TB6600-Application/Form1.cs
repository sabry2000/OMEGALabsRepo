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


using InstrumentLibrary;

namespace TB6600_Application
{
    public partial class Form1 : Form
    {
        private string selectedCOMPort;
        private TB6600StepperMotorDriver tb6600StepperMotorDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveDown();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveUp();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver = new TB6600StepperMotorDriver(selectedCOMPort);
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

        private void COMPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCOMPort = COMPortComboBox.SelectedItem.ToString();
        }
    }
}
