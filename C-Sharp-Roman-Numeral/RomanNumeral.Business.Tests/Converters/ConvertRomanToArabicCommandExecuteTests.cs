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
            Assert.AreEqual(1, new ConvertRomanToArabicCommand("1").Execute());
        }
    }
}