using log4net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using AutomationFramework.Core.Steps;
using AutomationFramework.Model;

namespace AutomationFramework.Core.Tests
{
    public class TestBuilder
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private AutomatedTester automatedTester;

        public TestBuilder(AutomatedTester automatedTester)
        {
            this.automatedTester = automatedTester;
        }

        public Test BuildFromXml(XElement xElement)
        {
            var test = new Test();

            test.TestSteps = new ObservableCollection<Step>(xElement.Elements("TestStep")
                .Select((x, i) => Step.CreateFromXml(x, i + 1, automatedTester))
                .OrderBy(x => x.StepIndex));
            test.PLMId = 0;
            test.PLMRevision = "TEST";
            test.Created = DateTimeOffset.Now;

            return test;
        }
    }
}
