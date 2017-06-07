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
            return _number > 0 ? "I" : "";
        }
    }
}