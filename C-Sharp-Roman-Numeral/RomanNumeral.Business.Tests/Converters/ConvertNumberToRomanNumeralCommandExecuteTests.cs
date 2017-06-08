using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Business.Converters;

namespace RomanNumeral.Business.Tests.Converters
{
    [TestClass]
    public class ConvertNumberToRomanNumeralCommandExecuteTests
    {
        [TestMethod]
        public void ShouldReturnBlankWhenZero()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(0).Execute();
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void ShouldConvertOne()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(1).Execute();
            Assert.AreEqual("I", actual);
        }

        [TestMethod]
        public void ShouldConvertFour()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(4).Execute();
            Assert.AreEqual("IV", actual);
        }

        [TestMethod]
        public void ShouldConvertFive()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(5).Execute();
            Assert.AreEqual("V", actual);
        }
    }
}