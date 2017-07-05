using NUnit.Framework;

namespace TrafficControl.Core.Tests
{
    public class MilitaryTimeTest
    {
        [TestCase("06:53", 653)]
        [TestCase("09:30", 930)]
        [TestCase("10:31", 1031)]
        [TestCase("14:28", 1428)]
        [TestCase("19:35", 1935)]
        public void TestTimeValue(string source, int expectedTime)
        {
            Assert.That(new MilitaryTime(source).Value(), Is.EqualTo(expectedTime));
        }
    }
}