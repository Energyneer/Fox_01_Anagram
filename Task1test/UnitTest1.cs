using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("", Anagram.Reverse(null));
            Assert.AreEqual("dcba hgfe", Anagram.Reverse("abcd efgh"));
            Assert.AreEqual("tseT", Anagram.Reverse("Test"));
            Assert.AreEqual("d1cba hgf!e", Anagram.Reverse("a1bcd efg!h"));
            Assert.AreEqual("  d1cba    hgf!e", Anagram.Reverse("  a1bcd    efg!h"));
        }
    }
}
