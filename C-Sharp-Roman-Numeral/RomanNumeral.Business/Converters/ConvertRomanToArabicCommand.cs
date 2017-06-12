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
            for (var i = 0; i < _romanNumeral.Length; i++)
            {
                if (ContainsKeyByLength(2)) TwoCharUpdate();
                else MultiCharConverter(i);
            }

            return _number;
        }

        private void MultiCharConverter(int index)
        {
            if (ContainsKeyByIndex(index)) Update(index);
            else UpdateNumber(_romanNumeral[index].ToString());
        }

        private static bool ContainsKeyByIndex(int index)
        {
            return _romanNumeral.Length - index >= 2 && ContainsKey(_romanNumeral.Substring(index, 2));
        }

        private static bool ContainsKeyByLength(int charLength)
        {
            return _romanNumeral.Length == charLength && ContainsKey(_romanNumeral);
        }

        private static bool ContainsKey(string roman)
        {
            return Mappers.RomanToArabicMapper.Mapper.ContainsKey(roman);
        }

        private void Update(int index)
        {
            UpdateNumber(_romanNumeral.Substring(index, 2));
            UpdateAndReplace(_romanNumeral.Substring(index, 2));
        }

        private void TwoCharUpdate()
        {
            UpdateNumber(_romanNumeral);
            UpdateAndReplace(_romanNumeral);
        }

        private static void UpdateAndReplace(string roman)
        {
            _romanNumeral = _romanNumeral.Replace(roman, string.Empty);
        }

        private void UpdateNumber(string character)
        {
            _number += Mappers.RomanToArabicMapper.Mapper[character];
        }
    }
}