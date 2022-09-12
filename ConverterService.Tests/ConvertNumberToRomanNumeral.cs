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
            _converterService.ConvertIntToRoman(4034).Should().Be(null);
            _converterService.ConvertIntToRoman(0).Should().Be(null);
            _converterService.ConvertIntToRoman(9).Should().Be("IX");

        }

    }
}