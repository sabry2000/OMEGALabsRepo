using InstrumentLibrary.TB6600;
using System;
using System.IO.Ports;
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
        }

        private void UnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUnits = Units.FromString(UnitsComboBox.SelectedItem.ToString());
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            tb6600StepperMotorDriver.Connect();
            Terminal.AppendText("Connection Established\n");
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
            CurrentPositionTextBox.Text = Units.Convert(tb6600StepperMotorDriver.Position, Unit.inch, currentUnits).ToString();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            var position = Double.Parse(MoveByTextBox.Text);
            MoveByTextBox.Clear();

            double positionInches = Math.Abs(Units.Convert(position, currentUnits, Unit.inch));

            if (position > 0)
                tb6600StepperMotorDriver.MoveUp(positionInches);
            else
                tb6600StepperMotorDriver.MoveDown(positionInches);

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
