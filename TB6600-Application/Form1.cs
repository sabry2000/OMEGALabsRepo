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
        private string units;
        private TB6600StepperMotorDriver tb6600StepperMotorDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveDown();
            UpdateTerminal();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveUp();
            UpdateTerminal();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver = new TB6600StepperMotorDriver(selectedCOMPort);
        }

        private void SetPosition_Click(object sender, EventArgs e)
        {
            var position = Double.Parse(SetPositionTextBox.Text);
            double positionInches;
            if (units.Equals("cm"))
                positionInches = 0.3937 * position;
            else if (units.Equals("mm"))
                positionInches = 3.937 * position;
            else
                positionInches = position;
            
            tb6600StepperMotorDriver.SetPosition(positionInches);
            UpdateTerminal();
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

        private void CalibrateButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.Calibrate();
            UpdateTerminal();
        }

        private void UpdateTerminal()
        {
            Terminal.AppendText(tb6600StepperMotorDriver.LastMessage);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            units = unitsComboBox.SelectedItem.ToString();
        }
    }
}
