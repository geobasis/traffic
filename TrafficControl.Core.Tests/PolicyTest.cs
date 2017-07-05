using System;
using NUnit.Framework;

namespace TrafficControl.Core.Tests
{
    public class PolicyTest
    {
        [TestCase("TPA-1833", "2017-07-04", "9:30", true)]
        [TestCase("TPA-1830", "2017-07-04", "9:30", false)]
        [TestCase("PXJ-0104", "2017-07-04", "06:59", false)]
        [TestCase("PXJ-0104", "2017-07-04", "07:01", true)]
        [TestCase("PXJ-0104", "2017-07-04", "09:31", false)]
        [TestCase("PXJ-0104", "2017-07-05", "08:30", false)]
        [TestCase("PXJ-0104", "2017-07-04", "15:59", false)]
        [TestCase("PXJ-0104", "2017-07-04", "16:00", true)]
        [TestCase("PXJ-0104", "2017-07-04", "19:30", true)]
        [TestCase("PXJ-0104", "2017-07-04", "19:31", false)]
        public void TestIsRestricted(string number, string date, string time, bool expectedRestriction)
        {
            var policy = new Policy(
                new LicencePlate(number), DateTime.Parse(date), new MilitaryTime(time));
            Assert.That(policy.IsRestricted(), Is.EqualTo(expectedRestriction));
        }   
    }
}