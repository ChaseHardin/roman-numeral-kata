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
            { "I", 1 }
        }; 
    }
}