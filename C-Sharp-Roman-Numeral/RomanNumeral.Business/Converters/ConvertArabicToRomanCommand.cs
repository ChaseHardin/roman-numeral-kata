using System.Linq;
using RomanNumeral.Business.Mappers;

namespace RomanNumeral.Business.Converters
{
    public class ConvertArabicToRomanCommand
    {
        private static int _number;
        private string _romanNumeral = string.Empty;

        public ConvertArabicToRomanCommand(int number)
        {
            _number = number;
        }

        public string Execute()
        {
            if (_number <= 0) return "";

            UpdateRomanNumeral();
            UpdateNumber();
            DoExecute();

            return _romanNumeral;
        }

        private void UpdateRomanNumeral()
        {
            _romanNumeral += ArabicToRomanMapper.Mapper[FindMaxKeyInDictionary()];
        }

        private static void UpdateNumber()
        {
            _number -= FindMaxKeyInDictionary();
        }

        private void DoExecute()
        {
            if (_number > 0) Execute();
        }

        private static int FindMaxKeyInDictionary()
        {
            return ArabicToRomanMapper.Mapper.Keys.Where(key => key <= _number).Max();
        }
    }
}