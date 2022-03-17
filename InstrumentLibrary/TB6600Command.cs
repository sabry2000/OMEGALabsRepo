using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentLibrary
{
    public class TB6600Command
    {
        private TB6600Command(char value) { Value = value; }
        public char Value { get; private set; }

        public static TB6600Command UP { get { return new TB6600Command('u'); } }
        public static TB6600Command DOWN { get { return new TB6600Command('d'); } }
    }
}
