using System;
using NUnit.Framework;

namespace TrafficControl.Core.Tests
{
    public class PolicyTest
    {
        [TestCase("TPA-1833", "2017-07-04", "9:30", true)]
        [TestCase("TPA-1830", "2017-07-04", "9:30", false)]
        public void TestIsRestricted(string number, string date, string time, bool expectedRestriction)
        {
            var policy = new Policy(
                new LicencePlate(number), DateTime.Parse(date), new MilitaryTime(time));
            Assert.That(policy.IsRestricted(), Is.EqualTo(expectedRestriction));
        }   
    }
}