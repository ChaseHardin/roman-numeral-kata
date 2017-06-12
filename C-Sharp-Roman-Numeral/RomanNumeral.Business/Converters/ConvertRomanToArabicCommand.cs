using System.Collections.Generic;

namespace RomanNumeral.Business.Converters
{
    public class ConvertRomanToArabicCommand
    {
        private static string _romanNumeral;
        private int _number;

        public ConvertRomanToArabicCommand(string romanNumeral)
        {
            _romanNumeral = romanNumeral;
        }

        public int Execute()
        {
            if (_romanNumeral.Length > 1 && RomanToArabicMapper.Mapper.ContainsKey(_romanNumeral.Substring(0, 2)))
                return RomanToArabicMapper.Mapper[_romanNumeral.Substring(0, 2)];

            UpdateNumeric();

            return _number;
        }

        private void UpdateNumeric()
        {
            foreach (var character in _romanNumeral)
            {
                _number += RomanToArabicMapper.Mapper[character.ToString()];
            }
        }
    }

    public static class RomanToArabicMapper
    {
        public static Dictionary<string, int> Mapper = new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC" , 90 },
            { "C", 100 }
        };
    }
}