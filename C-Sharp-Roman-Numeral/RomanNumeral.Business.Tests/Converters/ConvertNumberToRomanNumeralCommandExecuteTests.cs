using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Business.Converters;

namespace RomanNumeral.Business.Tests.Converters
{
    [TestClass]
    public class ConvertNumberToRomanNumeralCommandExecuteTests
    {
        [TestMethod]
        public void ShouldReturnEmptyStringWhenNumberIsNegative()
        {
            Assert.AreEqual("", new ConvertNumberToRomanNumeralCommand(-42).Execute());
        }

        [TestMethod]
        public void ShouldReturnBlankWhenZero()
        {
            Assert.AreEqual("", new ConvertNumberToRomanNumeralCommand(0).Execute());
        }

        [TestMethod]
        public void ShouldConvertOne()
        {
            Assert.AreEqual("I", new ConvertNumberToRomanNumeralCommand(1).Execute());
        }

        [TestMethod]
        public void ShouldConvertFour()
        {
            Assert.AreEqual("IV", new ConvertNumberToRomanNumeralCommand(4).Execute());
        }

        [TestMethod]
        public void ShouldConvertFive()
        {
            Assert.AreEqual("V", new ConvertNumberToRomanNumeralCommand(5).Execute());
        }

        [TestMethod]
        public void ShouldConvertNine()
        {
            Assert.AreEqual("IX", new ConvertNumberToRomanNumeralCommand(9).Execute());
        }

        [TestMethod]
        public void ShouldConvertTen()
        {
            Assert.AreEqual("X", new ConvertNumberToRomanNumeralCommand(10).Execute());
        }

        [TestMethod]
        public void ShouldConvertFourty()
        {
            Assert.AreEqual("XL", new ConvertNumberToRomanNumeralCommand(40).Execute());
        }

        [TestMethod]
        public void ShouldConvertFifty()
        {
            Assert.AreEqual("L", new ConvertNumberToRomanNumeralCommand(50).Execute());
        }

        [TestMethod]
        public void ShouldConvertNinty()
        {
            Assert.AreEqual("XC", new ConvertNumberToRomanNumeralCommand(90).Execute());
        }

        [TestMethod]
        public void ShouldConvertOneHundred()
        {
            Assert.AreEqual("L", new ConvertNumberToRomanNumeralCommand(100).Execute());
        }

        [TestMethod]
        public void ShouldConvertFourHundred()
        {
            Assert.AreEqual("LD", new ConvertNumberToRomanNumeralCommand(400).Execute());
        }

        [TestMethod]
        public void ShouldConvertFiveHundred()
        {
            Assert.AreEqual("D", new ConvertNumberToRomanNumeralCommand(500).Execute());
        }

        [TestMethod]
        public void ShouldConvertNineHundred()
        {
            Assert.AreEqual("CM", new ConvertNumberToRomanNumeralCommand(900).Execute());
        }

        [TestMethod]
        public void ShouldConvertOneThousand()
        {
            Assert.AreEqual("M", new ConvertNumberToRomanNumeralCommand(1000).Execute());
        }

        [TestMethod]
        public void ShouldConverFiftyFive()
        {
            Assert.AreEqual("LV", new ConvertNumberToRomanNumeralCommand(55).Execute());
        }
    }
}