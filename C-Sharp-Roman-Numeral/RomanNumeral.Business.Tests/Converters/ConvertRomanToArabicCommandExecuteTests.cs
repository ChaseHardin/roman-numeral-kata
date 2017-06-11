using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Business.Converters;

namespace RomanNumeral.Business.Tests.Converters
{
    [TestClass]
    public class ConvertRomanToArabicCommandExecuteTests
    {
        [TestMethod]
        public void ShouldConvertOne()
        {
            Assert.AreEqual(1, new ConvertRomanToArabicCommand("I").Execute());
        }

        [TestMethod]
        public void ShouldConvertTwo()
        {
            Assert.AreEqual(2, new ConvertRomanToArabicCommand("II").Execute());
        }
    }
}