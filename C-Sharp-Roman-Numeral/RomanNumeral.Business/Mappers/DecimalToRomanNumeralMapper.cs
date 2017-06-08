using System.Collections.Generic;

namespace RomanNumeral.Business.Mappers
{
    public static class DecimalToRomanNumeralMapper
    {
        public static Dictionary<int, string> Mapper = new Dictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" }
        };
    }
}