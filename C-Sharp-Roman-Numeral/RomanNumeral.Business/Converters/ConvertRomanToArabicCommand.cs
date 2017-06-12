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
            foreach (var t in _romanNumeral)
            {
                _number += RomanToArabicMapper.Mapper[t.ToString()];
            }

            return _number;
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