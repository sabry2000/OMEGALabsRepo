using System.Collections.Generic;

namespace InstrumentLibrary
{
    public class TB6600Command
    {
        private TB6600Command(string command) : this(command, new List<int>()) { }
        private TB6600Command(string command, List<int> arguments)
        {
            Command = command;
            Arguments = (List<int>)arguments;
        }
        public string Command { get; private set; }
        public List<int> Arguments { get; private set; }

        public static TB6600Command UP { get { return new TB6600Command("u"); } }
        public static TB6600Command DOWN { get { return new TB6600Command("d"); } }
        public static TB6600Command CALIBRATE { get { return new TB6600Command("c"); } }
        private static TB6600Command PULSES { get { return new TB6600Command("p"); } }

        public static TB6600Command PulsesCommand(int numberOfPulses)
        {
            TB6600Command cmd = PULSES;
            cmd.Arguments.Add(numberOfPulses);
            return cmd;
        }

        public string toString()
        {
            string commandString = Command;
            foreach (var arg in Arguments)
                commandString += (" " + arg.ToString());
            return commandString;
        }
    }
}
