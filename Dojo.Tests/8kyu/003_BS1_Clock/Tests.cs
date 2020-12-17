using NUnit.Framework;
using System;
using Call = Dojo.Kata._8kyu._003_BS1_Clock.after;

namespace Dojo.Tests._8kyu._003_BS1_Clock
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, Call.Kata.Past(0,1,1));
        }

        [Test]
        public void TestWithHours()
        {
            Assert.AreEqual(16813000, Call.Kata.Past(4, 40, 13));
        }

        [Test]
        public void RandomTests()
        {
            Random r = new Random();

            for (int d = 0; d < 100; d++)
            {
                int i = r.Next(24);
                int j = r.Next(60);
                int s = r.Next(60);
                Assert.AreEqual(Call.Kata.Past(i, j, s), Call.Kata.Past(i, j, s), "Failed at Past(" + i + "," + j + "," + s + ")");
            }
        }

    }
}
