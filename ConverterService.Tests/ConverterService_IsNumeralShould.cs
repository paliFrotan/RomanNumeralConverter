using Converter.Services;

namespace Converter.UnitTests.Services
{
    [TestFixture]
    public class ConverterService_IsNumeralShould
    {
        private ConverterService _converterService;

        [SetUp]
        public void SetUp()
        {
            _converterService = new ConverterService();
        }

        [Test]
        public void IsRomanNumeral()
        {
            //var number = _primeService.ConvertRomanToInt("I");

            //Assert.That(number,Is.EqualTo(1));
            // string romanNumeral = "I";
            _converterService.ConvertRomanToInt("I").Should().Be(1);
        }
    }
}