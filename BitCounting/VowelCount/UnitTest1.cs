using NUnit.Framework;

namespace VowelCount
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}