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

        [TestMethod]
        public void ShouldConvertThree()
        {
            Assert.AreEqual(3, new ConvertRomanToArabicCommand("III").Execute());
        }

        [TestMethod]
        public void ShouldConvertFour()
        {
            Assert.AreEqual(4, new ConvertRomanToArabicCommand("IV").Execute());
        }

        [TestMethod]
        public void ShouldConvertFive()
        {
            Assert.AreEqual(5, new ConvertRomanToArabicCommand("V").Execute());
        }

        [TestMethod]
        public void ShouldConvertNine()
        {
            Assert.AreEqual(9, new ConvertRomanToArabicCommand("IX").Execute());
        }

        [TestMethod]
        public void ShouldConvertTen()
        {
            Assert.AreEqual(10, new ConvertRomanToArabicCommand("X").Execute());
        }

        [TestMethod]
        public void ShouldConvertForty()
        {
            Assert.AreEqual(40, new ConvertRomanToArabicCommand("XL").Execute());
        }

        [TestMethod]
        public void ShouldConvertFifty()
        {
            Assert.AreEqual(50, new ConvertRomanToArabicCommand("L").Execute());
        }

        [TestMethod]
        public void ShouldConvertNinty()
        {
            Assert.AreEqual(90, new ConvertRomanToArabicCommand("XC").Execute());
        }

        [TestMethod]
        public void ShouldConvertOneHundred()
        {
            Assert.AreEqual(100, new ConvertRomanToArabicCommand("C").Execute());
        }

        [TestMethod]
        public void ShouldConvertFourHundred()
        {
            Assert.AreEqual(400, new ConvertRomanToArabicCommand("CD").Execute());
        }

        [TestMethod]
        public void ShouldConvertFiveHundred()
        {
            Assert.AreEqual(500, new ConvertRomanToArabicCommand("D").Execute());
        }

        [TestMethod]
        public void ShouldConvertNineHundred()
        {
            Assert.AreEqual(900, new ConvertRomanToArabicCommand("CM").Execute());
        }

        [TestMethod]
        public void ShouldConvertOneThousand()
        {
            Assert.AreEqual(1000, new ConvertRomanToArabicCommand("M").Execute());
        }

        [TestMethod]
        public void ShouldConvertOneThousandTwoHundredAndThirtyFour()
        {
            Assert.AreEqual(1234, new ConvertRomanToArabicCommand("MCCXXXIV").Execute());
        }
    }
}