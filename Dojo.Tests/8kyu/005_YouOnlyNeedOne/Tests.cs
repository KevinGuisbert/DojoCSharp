using NUnit.Framework;
using Call = Dojo.Kata._8kyu._005_YouOnlyNeedOne;

namespace Dojo.Tests._8kyu._005_YouOnlyNeedOne
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, Call.Kata.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, Call.Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));
            Assert.AreEqual(true, Call.Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));

            Assert.AreEqual(false, Call.Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
    }
}
