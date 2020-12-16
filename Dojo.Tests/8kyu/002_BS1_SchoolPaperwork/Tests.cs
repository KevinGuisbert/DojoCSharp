using NUnit.Framework;
using Call = Dojo.Kata._8kyu._002_BS1_SchoolPaperwork.after;

namespace Dojo.Tests._8kyu._002_BS1_SchoolPaperwork
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(25, Call.Kata.Paperwork(5, 5));
        }

        [Test]
        public void TestNegative()
        {
            Assert.AreEqual(0, Call.Kata.Paperwork(5, -5));
        }
    }
}
