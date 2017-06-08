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

        [TestMethod]
        public void ShouldConvertNine()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(9).Execute();
            Assert.AreEqual("IX", actual);
        }

        [TestMethod]
        public void ShouldConvertTen()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(10).Execute();
            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void ShouldConvertFourty()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(40).Execute();
            Assert.AreEqual("XL", actual);
        }

        [TestMethod]
        public void ShouldConvertFifty()
        {
            var actual = new ConvertNumberToRomanNumeralCommand(50).Execute();
            Assert.AreEqual("L", actual);
        }
    }
}