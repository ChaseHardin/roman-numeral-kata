namespace RomanNumeral.Business.Converters
{
    public class ConvertRomanToArabicCommand
    {
        private static string _romanNumeral;

        public ConvertRomanToArabicCommand(string romanNumeral)
        {
            _romanNumeral = romanNumeral;
        }

        public int Execute()
        {
            return 1;
        }
    }
}