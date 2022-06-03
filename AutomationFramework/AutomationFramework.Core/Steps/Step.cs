using AutomationFramework.Utils;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationFramework.Core.Steps
{
    public abstract class Step
    {
        private const string STR_StepTypeXml = "StepType";
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Step(int stepIndex, string description)
        {
            StepIndex = stepIndex;
            Description = description;
        }

        protected Step()
        {
        }

        public string Description { get; private set; }
        public int StepIndex { get; private set; }

        public static Step CreateFromXml(XElement xElement, int stepIndex, AutomatedTester automatedTester)
        {
            var stepTypesByName = FactoryHelper.LoadTypesToReturn<Step>();
            var stepType = stepTypesByName[$"{xElement.Attribute(STR_StepTypeXml).Value}"];
            var step = (Step)Activator.CreateInstance(stepType, true);
            step.Initialize(xElement, stepIndex, automatedTester);

            return step;
        }

        public abstract Task ExecuteAsync(CancellationToken ct);

        public override string ToString()
        {
            return $"Step {StepIndex}: {GetType().Name} - {Description}";
        }

        public virtual XElement ToXml()
        {
            var xElement = new XElement("TestStep");
            xElement.SetAttributeValue(STR_StepTypeXml, GetType().Name);
            xElement.Add(new XElement(nameof(Description), Description));
            return xElement;
        }

        protected virtual void Initialize(XElement xElement, int stepIndex, AutomatedTester automatedTester)
        {
            StepIndex = stepIndex;
            Description = xElement.Element(nameof(Description)).Value;
        }
    }
}