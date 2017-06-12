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
            for(var i = 0; i < _romanNumeral.Length; i++)
            {
                if (_romanNumeral.Length - i > 1 && Mappers.RomanToArabicMapper.Mapper.ContainsKey(_romanNumeral.Substring(i, 2)))
                {
                    _number += Mappers.RomanToArabicMapper.Mapper[_romanNumeral.Substring(i, 2)];
                    _romanNumeral = _romanNumeral.Replace(_romanNumeral.Substring(i, 2), string.Empty);
                }
                else
                    _number += Mappers.RomanToArabicMapper.Mapper[_romanNumeral[i].ToString()];
            }
        }
    }
}