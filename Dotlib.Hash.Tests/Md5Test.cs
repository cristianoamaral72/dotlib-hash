using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dotlib.Hash.Tests
{
    [TestClass]
    public class Md5Test
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("100100", "b9c93fbdfd2a30504e05d3b0b32307da")]
        [DataRow("123qwe", "46f94c8de14fb36680850768ff1b7f2a")]
        [DataRow("123456", "e10adc3949ba59abbe56e057f20f883e")]
        public void TestGenerate(string input, string expeected)
        {
            Assert.AreEqual(expeected, Md5.Generate(input));
        }
    }
}
