using NUnit.Framework;
using System;
using Call = Dojo.Kata._8kyu._004_BS1_Cockroach.after;

namespace Dojo.Tests._8kyu._004_BS1_Cockroach
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(30, Call.Kata.CockroachSpeed(1.08));
            Assert.AreEqual(30, Call.Kata.CockroachSpeed(1.09));
            Assert.AreEqual(0, Call.Kata.CockroachSpeed(0));
        }
    }
}
