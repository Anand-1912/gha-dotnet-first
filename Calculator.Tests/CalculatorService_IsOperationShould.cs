namespace Calculator.Tests
{
    public class CalculatorService_IsOperationShould
    {
        private readonly AdvancedCalculator _advancedCalculator;

        public CalculatorService_IsOperationShould()
        {
            _advancedCalculator = new AdvancedCalculator();
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _advancedCalculator.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        
        [Fact]
        public void AddReturnsCorrectSum()
        {

            var sum = _advancedCalculator.Add(10, 20);
            Assert.Equal(30, sum);
        }
        [Fact]
        public void SubReturnsCorrectDifference()
        {

            var difference = _advancedCalculator.Sub(20, 10);
            Assert.Equal(10, difference);
        }
        [Fact]
        public void MultiplyReturnsCorrectProduct()
        {

            var product = _advancedCalculator.Multiply(10, 20);
            Assert.Equal(200, product);
        }
        [Fact]
        public void DivideReturnsCorrectQuotient()
        {

            var quotient = _advancedCalculator.Divide(20, 10);
            Assert.Equal(2, quotient);
        }
    }
}

