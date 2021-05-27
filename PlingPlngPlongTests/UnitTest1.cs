using NUnit.Framework;
using Plingplangplong;
namespace PlingPlngPlongTests
{
    public class Tests
    {
        RainDrops raingDrops;
        [SetUp]
        public void Setup()
        {
            raingDrops = new RainDrops();
        }

        [TestCase(-3)]
        [TestCase(3)]
        [TestCase(108)]
        [TestCase(9999)]
        public void DivisibleBy3GivesPling(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "Pling");
        }
        [TestCase(-5)]
        [TestCase(5)]
        [TestCase(5000)]
        [TestCase(-50000)]
        public void DivisibleBy5GivesPlang(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "Plang");
        }

        [TestCase(-343)]
        [TestCase(7)]
        [TestCase(117649)]
        [TestCase(77777777)]
        [TestCase(-77777777)]
        public void DivisibleBy7GivesPlong(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "Plong");
        }

        [TestCase(2)]
        [TestCase(8192)]
        [TestCase(-202)]
        [TestCase(-1048576)]
        public void InvalidNumbersDontWork(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), number.ToString());
        }

        [TestCase(21)]
        [TestCase(-21)]
        [TestCase(-441)]
        [TestCase(194481)]
        [TestCase(-194481)]
        public void DivisibleBy21GivesPlingPlong(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "PlingPlong");
        }

        [TestCase(15)]
        [TestCase(-150000)]
        [TestCase(450)]
        [TestCase(-150000000)]
        [TestCase(150000000)]
        public void DivisibleBy15GivesPlingPlang(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "PlingPlang");
        }

        [TestCase(35)]
        [TestCase(-350000)]
        [TestCase(-35)]
        [TestCase(350)]
        public void DivisibleBy35GivesPlangPlong(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "PlangPlong");
        }

        [TestCase(0)]
        [TestCase(-1050000)]
        [TestCase(-105)]
        [TestCase(1050)]

        public void DivisibleBy105GivesPlingPlangplong(int number)
        {
            Assert.AreEqual(raingDrops.PlingPlangPlongConvert(number), "PlingPlangPlong");
        }
    }
}