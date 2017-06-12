using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Business.Converters;

namespace RomanNumeral.Business.Tests.Converters
{
    [TestClass]
    public class ConvertArabicToRomanCommandExecuteTests
    {
        [TestMethod]
        public void ShouldReturnEmptyStringWhenNumberIsNegative()
        {
            Assert.AreEqual("", new ConvertArabicToRomanCommand(-42).Execute());
        }

        [TestMethod]
        public void ShouldReturnBlankWhenZero()
        {
            Assert.AreEqual("", new ConvertArabicToRomanCommand(0).Execute());
        }

        [TestMethod]
        public void ShouldConvertOne()
        {
            Assert.AreEqual("I", new ConvertArabicToRomanCommand(1).Execute());
        }

        [TestMethod]
        public void ShouldConvertFour()
        {
            Assert.AreEqual("IV", new ConvertArabicToRomanCommand(4).Execute());
        }

        [TestMethod]
        public void ShouldConvertFive()
        {
            Assert.AreEqual("V", new ConvertArabicToRomanCommand(5).Execute());
        }

        [TestMethod]
        public void ShouldConvertNine()
        {
            Assert.AreEqual("IX", new ConvertArabicToRomanCommand(9).Execute());
        }

        [TestMethod]
        public void ShouldConvertTen()
        {
            Assert.AreEqual("X", new ConvertArabicToRomanCommand(10).Execute());
        }

        [TestMethod]
        public void ShouldConvertFourty()
        {
            Assert.AreEqual("XL", new ConvertArabicToRomanCommand(40).Execute());
        }

        [TestMethod]
        public void ShouldConvertFifty()
        {
            Assert.AreEqual("L", new ConvertArabicToRomanCommand(50).Execute());
        }

        [TestMethod]
        public void ShouldConvertNinty()
        {
            Assert.AreEqual("XC", new ConvertArabicToRomanCommand(90).Execute());
        }

        [TestMethod]
        public void ShouldConvertOneHundred()
        {
            Assert.AreEqual("C", new ConvertArabicToRomanCommand(100).Execute());
        }

        [TestMethod]
        public void ShouldConvertFourHundred()
        {
            Assert.AreEqual("LD", new ConvertArabicToRomanCommand(400).Execute());
        }

        [TestMethod]
        public void ShouldConvertFiveHundred()
        {
            Assert.AreEqual("D", new ConvertArabicToRomanCommand(500).Execute());
        }

        [TestMethod]
        public void ShouldConvertNineHundred()
        {
            Assert.AreEqual("CM", new ConvertArabicToRomanCommand(900).Execute());
        }

        [TestMethod]
        public void ShouldConvertOneThousand()
        {
            Assert.AreEqual("M", new ConvertArabicToRomanCommand(1000).Execute());
        }

        [TestMethod]
        public void ShouldConverFiftyFive()
        {
            Assert.AreEqual("LV", new ConvertArabicToRomanCommand(55).Execute());
        }
    }
}