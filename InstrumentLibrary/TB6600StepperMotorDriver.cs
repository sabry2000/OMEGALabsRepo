using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;

namespace InstrumentLibrary
{
    public class TB6600StepperMotorDriver
    {
        const double DOUBLE_INCHES_PER_REVOLUTION = 0.1875;
        const int INT_BAUD_RATE = 9600; 

        private readonly string m_COMPort;
        private SerialPort m_serialPort;
        private IList<TB6600Command> m_commandBuffer = new List<TB6600Command>();

        public TB6600StepperMotorDriver(String COMPort)
        {
            m_COMPort = COMPort;
            m_serialPort = new SerialPort(COMPort, INT_BAUD_RATE);
            m_serialPort.Open();
        }

        public void QueueCommand(TB6600Command cmd)
        {
            m_commandBuffer.Add(cmd);
        }

        public void ExecuteCommand()
        {
            string commandBuffer = "";
            foreach (var cmd in m_commandBuffer)
            {
                commandBuffer += cmd.Value;
            }
            
            m_serialPort.WriteLine(commandBuffer);
            m_commandBuffer.Clear();
        }



        public void Calibrate()
        {

        }

        public void MoveUp()
        {
            QueueCommand(TB6600Command.UP);
            ExecuteCommand();
        }

        public void MoveUp(double distanceInches)
        {
            var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
            var numberOfWholeRevolutions = (int)numberOfRevolutions;
            var revolutionFractionRemaining = ((decimal)numberOfRevolutions % 1);

            for (int i = 0; i < numberOfWholeRevolutions; i++)
            {
                QueueCommand(TB6600Command.UP);
            }

            ExecuteCommand();
        }

        public void MoveDown()
        {
            QueueCommand(TB6600Command.DOWN);
            ExecuteCommand();
        }

        public void MoveDown(double distanceInches)
        {
            var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
            var numberOfWholeRevolutions = (int)numberOfRevolutions;
            var revolutionFractionRemaining = ((decimal)numberOfRevolutions % 1);

            for (int i = 0; i < numberOfWholeRevolutions; i++)
            {
                QueueCommand(TB6600Command.DOWN);
            }

            ExecuteCommand();
        }


        ~TB6600StepperMotorDriver()
        {
            m_serialPort.Close();
        }
    }
}
