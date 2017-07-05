using NUnit.Framework;

namespace TrafficControl.Core.Tests
{
    public class MilitaryTimeTest
    {
        [TestCase("9:30", 930)]
        [TestCase("10:31", 1031)]
        [TestCase("14:28", 1428)]
        public void TestParse(string source, int expectedTime)
        {
            Assert.That(MilitaryTime.Parse(source), Is.EqualTo(expectedTime));
        }
    }
}