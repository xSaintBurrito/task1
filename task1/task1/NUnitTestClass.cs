using NUnit.Framework;
using System;
namespace task1
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test]
        public void TestCase()
        {
            Assert.Equals(true, false);
        }
        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            Assert.Equals(true, false);
        }
    }
}
