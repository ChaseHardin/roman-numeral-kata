using System.Linq;
using RomanNumeral.Business.Mappers;

namespace RomanNumeral.Business.Converters
{
    public class ConvertNumberToRomanNumeralCommand
    {
        private readonly int _number;

        public ConvertNumberToRomanNumeralCommand(int number)
        {
            _number = number;
        }

        public string Execute()
        {
            return _number <= 0 ? "" : DecimalToRomanNumeralMapper.Mapper[FindMaxKeyInDictionary(_number)];
        }

        private static int FindMaxKeyInDictionary(int number)
        {
            return DecimalToRomanNumeralMapper.Mapper.Keys.Where(key => key <= number).Max();
        }
    }
}