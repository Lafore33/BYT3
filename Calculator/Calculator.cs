namespace BYT3_2
{

    public class Calculator(double a, double b, char op)
    {
        private double _a = a;
        private double _b = b;
        private char _op = op;

        public double Calculate()
        {
            return _op switch
            {
                '+' => _a + _b,
                '-' => _a - _b,
                '*' => _a * _b,
                '/' => _b != 0 ? _a / _b : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException()
            };

        }
    }
}