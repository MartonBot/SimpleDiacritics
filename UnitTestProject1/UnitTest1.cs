using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDiacritics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStrip1()
        {
            string accentuatedChars = "àâäçèéêëîïôöùûü";
            string expected = "aaaceeeeiioouuu";

            var processor = new TextProcessor();

            string actual = processor.Strip(accentuatedChars);

            Assert.AreEqual(expected, actual);

        }
    }
}
