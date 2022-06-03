using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using AutomationFramework.Core.Steps;
using AutomationFramework.Model;
using AutomationFramework.Utils;
using GalaSoft.MvvmLight;

namespace AutomationFramework.Core.Tests
{
    public class Test : ObservableObject
    {
        private ObservableCollection<Step> testSteps = new ObservableCollection<Step>();

        public int PLMId { get; set; }

        public string PLMRevision { get; set; }

        public ObservableCollection<Step> TestSteps
        {
            get { return testSteps; }
            set { Set(ref testSteps, value); }
        }

        public string Title { get; set; }
        public int DatabaseId { get; set; }
        public DateTimeOffset Created { get; set; }
        public string ApprovedBy { get; set; }
        public bool IsApproved { get; set; }

        public XElement ToXml()
        {
            var xElement = new XElement(nameof(TestSteps));
            xElement.Add(TestSteps.OrderBy(x => x.StepIndex).Select(x => x.ToXml()).ToList());
            return xElement;
        }

        public bool IsEquivalentTo(Protocol other)
        {
            return Title == other?.Title &&
                PLMId == other?.PLMId &&
                PLMRevision == other?.PLMRevision &&
                ToXml().ToString().ToSHA1(Encoding.UTF8) == other?.Hash;
        }
    }
}