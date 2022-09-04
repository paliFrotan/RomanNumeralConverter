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
        public void IsRomanNumeralcorrectsum()
        {
            _converterService.ConvertRomanToInt("I").Should().Be(1);
            _converterService.ConvertRomanToInt(null).Should().Be(0);
            _converterService.ConvertRomanToInt("III").Should().Be(3);

        }

    }
}