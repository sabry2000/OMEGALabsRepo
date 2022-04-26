﻿using System;
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
        const int INT_MAXIMUM_UC_INT = 32767;

        private readonly string m_COMPort;
        private SerialPort m_serialPort;
        private IList<TB6600Command> m_commandBuffer = new List<TB6600Command>();

        public double Position { get; private set; }
        public string LastMessage { get; private set; }

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

        public void ExecuteCommands()
        {
            foreach (var cmd in m_commandBuffer)
            {
                m_serialPort.WriteLine(cmd.toString());
                LastMessage = m_serialPort.ReadLine();
            }
            m_commandBuffer.Clear();
        }

        public void Calibrate()
        {
            QueueCommand(TB6600Command.CALIBRATE);
            ExecuteCommands();
            Position = 0;
        }

        public void SetPosition(double positionInches)
        {

            double distanceInches = positionInches - Position;
            if (distanceInches > 0)
                MoveUp(distanceInches);
            else
                MoveDown(distanceInches);
        }

        public void Move(double distanceInches)
        {
            var numberOfRevolutions = Math.Abs(distanceInches / DOUBLE_INCHES_PER_REVOLUTION);
            int numberOfPulses = (int)(DOUBLE_PULSES_PER_REVOLUTION * numberOfRevolutions);

            TB6600Command cmd = distanceInches > 0 ? TB6600Command.UP : TB6600Command.DOWN;

            QueueCommand(TB6600Command.PulsesCommand(numberOfPulses));
            QueueCommand(cmd);
            ExecuteCommands();
        }

        public void MoveUp()
        {
            QueueCommand(TB6600Command.UP);
            ExecuteCommands();
        }

        public void MoveUp(double distanceInches)
        {
            var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
            int numberOfPulses = (int)(DOUBLE_PULSES_PER_REVOLUTION * numberOfRevolutions);

            int numberOfPulsesAtMaxSize = numberOfPulses / INT_MAXIMUM_UC_INT;
            var remainingPulses = numberOfPulses % INT_MAXIMUM_UC_INT;

            QueueCommand(TB6600Command.PulsesCommand(INT_MAXIMUM_UC_INT));
            for (int i = 0; i < numberOfPulsesAtMaxSize; i++)
                QueueCommand(TB6600Command.UP);
            QueueCommand(TB6600Command.PulsesCommand(remainingPulses));
            QueueCommand(TB6600Command.UP);
            ExecuteCommands();

        }

        public void MoveDown()
        {
            QueueCommand(TB6600Command.DOWN);
            ExecuteCommands();
        }

        public void MoveDown(double distanceInches)
        {
            var numberOfRevolutions = distanceInches / DOUBLE_INCHES_PER_REVOLUTION;
            int numberOfPulses = (int)(DOUBLE_PULSES_PER_REVOLUTION * numberOfRevolutions);

            int numberOfPulsesAtMaxSize = numberOfPulses / INT_MAXIMUM_UC_INT;
            var remainingPulses = numberOfPulses % INT_MAXIMUM_UC_INT;

            QueueCommand(TB6600Command.PulsesCommand(INT_MAXIMUM_UC_INT));
            for (int i = 0; i < numberOfPulsesAtMaxSize; i++)
                QueueCommand(TB6600Command.DOWN);
            QueueCommand(TB6600Command.PulsesCommand(remainingPulses));
            QueueCommand(TB6600Command.DOWN);
            ExecuteCommands();
        }


        ~TB6600StepperMotorDriver()
        {
            m_serialPort.Close();
        }
    }
}
