namespace Converter.Services
{
    public class ConvertNumberToRomanNumeral
    {

        public string ConvertIntToRoman(int number)
        {
            if (number <= 0  || number > 4000) { return null; }
             
            string RomanNumerals = "";

            string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            for (int i = 0; i < number / 1000; i++)
            {
                RomanNumerals += "M";
            };
           
            RomanNumerals += NumberDivision(100, number, hundreds, RomanNumerals);
            RomanNumerals += NumberDivision(10, number, tens, RomanNumerals);
            RomanNumerals += NumberDivision(1, number, ones, RomanNumerals);

            return RomanNumerals;
        }
        public string NumberDivision(int units, int number, string[] unitsArray, string output)
        {
            int unitsIndex;
            if (units == 1)
            {
                unitsIndex = (number % 10);
            }
            else
            { 
                units *= 10;
                unitsIndex = (number / units);
                unitsIndex %= units / 10;
            } 
            return output += unitsArray[unitsIndex];
        }

    }

}
