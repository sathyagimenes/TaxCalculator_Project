using MyTaxCalculator.Domain;

namespace MyTaxCalculator.XunitUnitTests
{
    public class TiersUnitTest
    {
        [Theory]
        [InlineData(1,0)]
        public void DefineRate_CorrectRate_ReturnCorrectRate(double amount, int expectedResult)
        {
            Tiers sut = new Tiers();

            var result = sut.DefineRate(amount);

            Assert.Equal(expectedResult, result);
        }
    }
}