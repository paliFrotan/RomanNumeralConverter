using Converter.Services;

namespace Converter.UnitTests.Services
{
    [TestFixture]
    public class ConverterService_IsNumberShould
    {
        private ConvertNumberToRomanNumeral _converterService;

        [SetUp]
        public void SetUp()
        {
            _converterService = new ConvertNumberToRomanNumeral();
        }

        [Test]
        public void IsRomanNumeralcorrectsum()
        {
            _converterService.ConvertIntToRoman(1).Should().Be("I");
            _converterService.ConvertIntToRoman(4034).Should().Be("");
            _converterService.ConvertIntToRoman(0).Should().Be("");
            _converterService.ConvertIntToRoman(9).Should().Be("IX");
            _converterService.ConvertIntToRoman(11).Should().Be("XI");
            _converterService.ConvertIntToRoman(201).Should().Be("CCI");

        }

    }
}