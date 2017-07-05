using NUnit.Framework;

namespace TrafficControl.Core.Tests
{
    public class LicensePlateTest
    {
        [TestCase("TPA-1833", 3)]
        [TestCase("PXJ-0104", 4)]
        [TestCase("TPB-1855", 5)]
        public void TestLastDigit(string number, int expectedLastDigit)
        {
            var licensePlate = new LicencePlate(number);
            Assert.That(licensePlate.LastDigit, Is.EqualTo(expectedLastDigit));
        }
    }
}