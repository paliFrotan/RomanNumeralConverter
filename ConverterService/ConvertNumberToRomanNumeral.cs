namespace Converter.Services
{
    public class ConvertNumberToRomanNumeral
    {

        public string ConvertIntToRoman(int number)
        {
            if (number <= 0  || number > 4000) { return null; }
             
            string RomanNumerals = "";

            for (int i = 0; i < number / 1000; i++)
            {
                RomanNumerals += "M";
            };
           
            for(int i = 0; i < 3; i++)
            {
                RomanNumerals += NumberDivision(100/((int)Math.Pow(10, i)), number, RomanNumerals);
            }

            return RomanNumerals;
        }

        public string NumberDivision(int units, int number, string output)
        {
            Dictionary<int, string> romanNumbersDictionary = new()
                {
                    { 100,"C"}, { 200,"CC"}, { 300,"CCC"},{ 400,"CD"}, {500,"D" },{600, "DC" }, {700,"DCC" }, {800, "DCCC" }, {900,"CM" },
                    { 10,"X"}, { 20,"XX"}, { 30,"XXX"},{ 40,"XL"}, {50,"L" },{60, "LX" }, {70,"LXX" }, {80, "LXXX" }, {90,"XC" },
                    { 0,""},{ 1,"I"}, { 2,"II"}, { 3,"III"},{ 4,"IV"}, {5,"V" },{6, "VI" }, {7,"VII" }, {8, "VIII" }, {9,"IX" }

                };
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
            return output += romanNumbersDictionary[unitsIndex];
        }

    }

}
