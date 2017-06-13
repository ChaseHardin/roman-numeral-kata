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
                if (HasTwoCharKey())
                {
                    UpdateNumber(_romanNumeral);
                    Erase(_romanNumeral);
                }
                else MultiCharConverter(i);
            }

            return _number;
        }

        private void MultiCharConverter(int index)
        {
            if (HasKeyByIndex(index))
            {
                UpdateNumber(_romanNumeral.Substring(index, 2));
                Erase(_romanNumeral.Substring(index, 2));
            }
            else UpdateNumber(_romanNumeral[index].ToString());
        }

        private static bool HasKeyByIndex(int index)
        {
            return _romanNumeral.Length - index >= 2 && HasKey(_romanNumeral.Substring(index, 2));
        }

        private static bool HasTwoCharKey()
        {
            return _romanNumeral.Length == 2 && HasKey(_romanNumeral);
        }

        private static bool HasKey(string roman)
        {
            return Mappers.RomanToArabicMapper.Mapper.ContainsKey(roman);
        }

        private static void Erase(string roman)
        {
            _romanNumeral = _romanNumeral.Replace(roman, string.Empty);
        }

        private void UpdateNumber(string roman)
        {
            _number += Mappers.RomanToArabicMapper.Mapper[roman];
        }
    }
}