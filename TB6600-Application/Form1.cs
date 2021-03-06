using InstrumentLibrary.TB6600;
using System;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TB6600_Application
{
    public partial class LinearStagesApplication : Form
    {
        private string selectedCOMPort;
        private Unit currentUnits;
        private TB6600StepperMotorDriver tb6600StepperMotorDriver;

        public LinearStagesApplication()
        {
            InitializeComponent();
            UnitsComboBox.Items.Clear();
            UnitsComboBox.Items.AddRange((object[])Units.GetAllUnits());
            UnitsComboBox.SelectedItem = Unit.inch.ToString();
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
            tb6600StepperMotorDriver = new TB6600StepperMotorDriver(selectedCOMPort);
            Terminal.AppendText(String.Format("Selected Port: {0}\n", selectedCOMPort));
        }

        private void UnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUnits = Units.FromString(UnitsComboBox.SelectedItem.ToString());
            Terminal.AppendText(String.Format("Set Units to: {0}\n", currentUnits.ToString()));
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!tb6600StepperMotorDriver.isConnected())
            {
                tb6600StepperMotorDriver.Connect();
                Terminal.AppendText(String.Format("Connected to {0} Successfully\n", selectedCOMPort));
                ConnectButton.Text = "Disconnect";
            }
            else
            {
                tb6600StepperMotorDriver.Disconnect();
                ConnectButton.Text = "Connect";
                Terminal.AppendText(String.Format("Disconnected from {0}\n", selectedCOMPort));
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveUp();
            UpdateUI();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.MoveDown();
            UpdateUI();
        }

        private void CalibrateButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.Calibrate();
            UpdateUI();
        }

        private void SetPosition_Click(object sender, EventArgs e)
        {
            var position = Double.Parse(SetPositionTextBox.Text);
            SetPositionTextBox.Clear();

            var positionInches = Units.Convert(position, currentUnits, Unit.inch);

            tb6600StepperMotorDriver.SetPosition(positionInches);
            UpdateUI();
        }

        private void UpdateUI()
        {
            Terminal.AppendText(tb6600StepperMotorDriver.LastMessage);
            CurrentPositionTextBox.Text = Units.Convert(tb6600StepperMotorDriver.PositionInches, Unit.inch, currentUnits).ToString();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            var distance = Double.Parse(MoveByTextBox.Text);
            MoveByTextBox.Clear();

            double positionInches = Units.Convert(distance, currentUnits, Unit.inch);
            tb6600StepperMotorDriver.Move(positionInches);

            UpdateUI();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            StartTextBox.Text = "0";
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            var maxHeightInches = TB6600StepperMotorDriver.INT_MAX_HEIGHT_INCHES;
            var maxHeight = Units.Convert(maxHeightInches, Unit.inch, currentUnits);
            EndTextBox.Text = maxHeight.ToString();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            var start = Double.Parse(StartTextBox.Text);
            var end = Double.Parse(EndTextBox.Text);
            var steps = Int32.Parse(StepsTextBox.Text);
            var delay = Double.Parse(DelayTextBox.Text);

            StartTextBox.Clear();
            EndTextBox.Clear();
            StepsTextBox.Clear();
            DelayTextBox.Clear();

            Terminal.AppendText(String.Format("Executing Sweep from {0} ({4}) to {1} ({4})\n" +
                "Number Of Steps: {2}\n" +
                "Delay (ms): {3}\n",
                start, end, steps, delay, currentUnits.ToString()));

            var delta = (end - start) / steps;

            var startPosition = Units.Convert(start, currentUnits, Unit.inch);
            
            delta = Units.Convert(delta, currentUnits, Unit.inch);

            tb6600StepperMotorDriver.SetPosition(startPosition);
            UpdateUI();

            for (int i = 0; i < steps; i++)
            {
                tb6600StepperMotorDriver.Move(delta);
                UpdateUI();
                Thread.Sleep((int)delay);
            }
        }
    }
}
