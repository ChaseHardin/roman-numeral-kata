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
            if (_romanNumeral.Length > 1 && Mappers.RomanToArabicMapper.Mapper.ContainsKey(_romanNumeral.Substring(0, 2)))
                return Mappers.RomanToArabicMapper.Mapper[_romanNumeral.Substring(0, 2)];

            UpdateNumeric();

            return _number;
        }

        private void UpdateNumeric()
        {
            foreach (var character in _romanNumeral)
            {
                _number += Mappers.RomanToArabicMapper.Mapper[character.ToString()];
            }
        }
    }
}