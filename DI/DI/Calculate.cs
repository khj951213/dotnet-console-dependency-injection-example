namespace DI
{
    public class Calculate
    {
        private readonly ICalculator _calculator;
        public Calculate(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int AddMyNumbers() => _calculator.Add(1, 3);
    }
}
