namespace CalculatorLibrary
{
    public class AdvancedCalculator
    {
        public int Add(int x, int b) => x + b;
        public int Sub(int x, int b) => x - b;
        public int Multiply(int x, int b) => x * b;
        public int Divide(int x, int b) => x / b;
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not implemented.");
        }
    }
}
