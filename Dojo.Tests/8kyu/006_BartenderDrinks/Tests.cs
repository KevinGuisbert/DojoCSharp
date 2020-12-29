using NUnit.Framework;
using Call = Dojo.Kata._8kyu._006_BartenderDrinks;

namespace Dojo.Tests._8kyu._006_BartenderDrinks
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Patron Tequila", Call.Kata.GetDrinkByProfession("jabrOni"), "'Jabroni' should map to 'Patron Tequila'");
            Assert.AreEqual("Anything with Alcohol", Call.Kata.GetDrinkByProfession("scHOOl counselor"), "'School Counselor' should map to 'Anything with alcohol'");
            Assert.AreEqual("Hipster Craft Beer", Call.Kata.GetDrinkByProfession("prOgramMer"), "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.AreEqual("Moonshine", Call.Kata.GetDrinkByProfession("bike ganG member"), "'Bike Gang Member' should map to 'Moonshine'");
            Assert.AreEqual("Your tax dollars", Call.Kata.GetDrinkByProfession("poLiTiCian"), "'Politician' should map to 'Your tax dollars'");
            Assert.AreEqual("Cristal", Call.Kata.GetDrinkByProfession("rapper"), "'Rapper' should map to 'Cristal'");
            Assert.AreEqual("Beer", Call.Kata.GetDrinkByProfession("pundit"), "'Pundit' should map to 'Beer'");
            Assert.AreEqual("Beer", Call.Kata.GetDrinkByProfession("Pug"), "'Pug' should map to 'Beer'");
        }
    }
}
