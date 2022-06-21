using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace InstrumentLibrary.TB6600
{
    public class TB6600StepperMotorDriver
    {
        public const int INT_MAX_HEIGHT_INCHES = 12;
        private const double DOUBLE_INCHES_PER_REVOLUTION = 0.1875;
        private const int DOUBLE_PULSES_PER_REVOLUTION = 6400;
        private const int INT_BAUD_RATE = 9600;

        private const String STR_LOCATION_STRING = "Current Location: ";

        private readonly string m_COMPort;
        private SerialPort m_serialPort;
        private IList<TB6600Command> m_commandBuffer = new List<TB6600Command>();

        public double PositionInches { get; private set; }
        public string LastMessage { get; private set; }

        public TB6600StepperMotorDriver(String COMPort)
        {
            m_COMPort = COMPort;
            m_serialPort = new SerialPort(COMPort, INT_BAUD_RATE);
        }

        public bool isConnected() { return m_serialPort.IsOpen; }

        public void Connect()
        {
            m_serialPort.Open();
        }

        public void Disconnect()
        {
            m_serialPort.Close();
        }

        public void QueueCommand(TB6600Command cmd)
        {
            m_commandBuffer.Add(cmd);
        }

        public void ExecuteCommands()
        {
            QueueCommand(TB6600Command.LOCATION);

            foreach (var cmd in m_commandBuffer)
            {
                m_serialPort.WriteLine(cmd.toString());
                LastMessage = m_serialPort.ReadLine();
            }
            m_commandBuffer.Clear();

            UpdateLocation();
        }

        private void UpdateLocation()
        {
            PositionInches = Double.Parse(LastMessage.Split(' ')[2]);
        }

        public void Calibrate()
        {
            QueueCommand(TB6600Command.CALIBRATE);
            ExecuteCommands();
            //PositionInches = 0;
        }

        public void SetPosition(double positionInches)
        {

            double distanceInches = Math.Abs(positionInches - PositionInches);
            if (positionInches > 0)
                MoveUp(distanceInches);
            else
                MoveDown(distanceInches);

            //PositionInches = positionInches;
        }

        public void Move(double distanceInches)
        {
            if (distanceInches > 0)
                MoveUp(distanceInches);
            else
                MoveDown(Math.Abs(distanceInches));
        }

        public void MoveUp()
        {
            QueueCommand(TB6600Command.PulsesCommand(DOUBLE_PULSES_PER_REVOLUTION));
            QueueCommand(TB6600Command.UP);
            ExecuteCommands();

            //PositionInches += DOUBLE_INCHES_PER_REVOLUTION;
        }

        private void MoveUp(double distanceInches)
        {
            if (distanceInches > 0)
            {
                var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
                int numberOfPulses = (int)(DOUBLE_PULSES_PER_REVOLUTION * numberOfRevolutions);

                QueueCommand(TB6600Command.PulsesCommand(numberOfPulses));
                QueueCommand(TB6600Command.UP);
                ExecuteCommands();
                
               // PositionInches += distanceInches;
            }
        }

        public void MoveDown()
        {
            QueueCommand(TB6600Command.PulsesCommand(DOUBLE_PULSES_PER_REVOLUTION));
            QueueCommand(TB6600Command.DOWN);
            ExecuteCommands();

            //PositionInches -= DOUBLE_INCHES_PER_REVOLUTION;
        }

        private void MoveDown(double distanceInches)
        {
            if (distanceInches > 0)
            {
                var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
                int numberOfPulses = (int)(DOUBLE_PULSES_PER_REVOLUTION * numberOfRevolutions);

                QueueCommand(TB6600Command.PulsesCommand(numberOfPulses));
                QueueCommand(TB6600Command.DOWN);
                ExecuteCommands();

                // PositionInches -= distanceInches;
            }
        }


        ~TB6600StepperMotorDriver()
        {
            Disconnect();
        }
    }
}
