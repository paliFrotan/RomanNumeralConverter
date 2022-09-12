namespace Converter.Services
{
    public class ConverterService
    {
        
        public int ConvertRomanToInt(string s)
        {
            int sum = 0;
            if (s != null)
            {
                Dictionary<char, int> romanNumbersDictionary = new()
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                };
                
                for (int i = 0; i < s.Length; i++)
                {
                    char currentRomanChar = s[i];
                    romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                    if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                    {
                        sum -= num;
                    }
                    else
                    {
                        sum += num;
                    }
                }
                
            };
            return sum;
        }

    }
    

}

