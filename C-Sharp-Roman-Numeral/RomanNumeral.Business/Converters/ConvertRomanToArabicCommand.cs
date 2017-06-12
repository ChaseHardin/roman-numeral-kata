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
                if (TwoCharacterKeyMap()) TwoCharacterMapperPlan();
                else MapperPlan(i);
            }

            return _number;
        }

        private void TwoCharacterMapperPlan()
        {
            UpdateNumber(_romanNumeral);
            UpdateAndReplace(_romanNumeral);
        }

        private void MapperPlan(int index)
        {
            if (CharacterMap(index)) MapperMatch(index);
            else UpdateNumber(_romanNumeral[index].ToString());
        }

        private void MapperMatch(int index)
        {
            UpdateNumber(_romanNumeral.Substring(index, 2));
            UpdateAndReplace(_romanNumeral.Substring(index, 2));
        }

        private static bool CharacterMap(int index)
        {
            return _romanNumeral.Length - index >= 2 && ContainsKey(_romanNumeral.Substring(index, 2));
        }

        private static bool TwoCharacterKeyMap()
        {
            return _romanNumeral.Length == 2 && ContainsKey(_romanNumeral);
        }

        private static bool ContainsKey(string roman)
        {
            return Mappers.RomanToArabicMapper.Mapper.ContainsKey(roman);
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