using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using InstrumentLibrary.TB6600;

namespace AutomationFramework.Core.Steps
{
    public class TB66000CalibrationStep : Step
    {
        private const string STR_TB6600CalibrationXml = "TB6600Calibration";
        private TB6600StepperMotorDriver tb6600StepperMotorDriver;


        public TB66000CalibrationStep(TB6600StepperMotorDriver tb6600StepperMotorDriver, int stepIndex, string description) : base(stepIndex, description)
        {
            this.tb6600StepperMotorDriver = tb6600StepperMotorDriver;
        }

        protected TB66000CalibrationStep()
            : base()
        {
        }

        public override Task ExecuteAsync(CancellationToken ct)
        {
            tb6600StepperMotorDriver.Calibrate();
            return Task.CompletedTask;
        }

        public override XElement ToXml()
        {
            var xElement = base.ToXml();
            xElement.Add(new XElement(STR_TB6600CalibrationXml));
            return xElement;
        }

        protected override void Initialize(XElement xElement, int stepIndex, AutomatedTester automatedTester)
        {
            base.Initialize(xElement, stepIndex, automatedTester);
            tb6600StepperMotorDriver = automatedTester.tb6600StepperMotorDriver;
        }
    }
}
