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
            throw new System.NotImplementedException();
        }
    }
}