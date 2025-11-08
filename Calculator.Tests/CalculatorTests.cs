using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {

        [Test]
        public void AdditionReturnsCorrectResultForTwoPositives()
        {
            var calc = new BYT3_2.Calculator(2, 3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }
        
        [Test]
        public void AdditionReturnsCorrectResultForTwoNegatives()
        {
            var calc = new BYT3_2.Calculator(-2, -3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(-5));
        }

        [Test]
        public void AdditionReturnsCorrectResultForPositiveAndNegative()
        {
            var calc = new BYT3_2.Calculator(1, -3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void AdditionReturnsCorrectResultForZeroes()
        {
            var calc = new BYT3_2.Calculator(0, 0, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }
        
        [Test]
        public void SubtractionReturnsCorrectResultForTwoPositives()
        {
            var calc = new BYT3_2.Calculator(5, 3, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void SubtractionReturnsCorrectResultForTwoPositiveDecimals()
        {
            var calc = new BYT3_2.Calculator(5.1, 3.1, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(2.0).Within(0.001));
        }

        [Test]
        public void SubtractionReturnsCorrectResultForTwoNegatives()
        {
            var calc = new BYT3_2.Calculator(-5, -3, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void SubtractionReturnsCorrectResultForPositiveAndNegative()
        {
            var calc = new BYT3_2.Calculator(5, -3, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(8));
        }

        [Test]
        public void SubtractionReturnsCorrectResultForZeroes()
        {
            var calc = new BYT3_2.Calculator(0, 0, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }


        [Test]
        public void MultiplicationReturnsCorrectResultForTwoPositives()
        {
            var calc = new BYT3_2.Calculator(2, 3, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void MultiplicationReturnsCorrectResultForTwoNegatives()
        {
            var calc = new BYT3_2.Calculator(-2, -3, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void MultiplicationReturnsCorrectResultForPositiveAndNegative()
        {
            var calc = new BYT3_2.Calculator(2, -3, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(-6));
        }

        [Test]
        public void MultiplicationReturnsCorrectResultForZero()
        {
            var calc = new BYT3_2.Calculator(5, 0, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }

        [Test]
        public void DivisionReturnsCorrectResultForTwoPositives()
        {
            var calc = new BYT3_2.Calculator(6, 3, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void DivisionReturnsCorrectResultForTwoNegatives()
        {
            var calc = new BYT3_2.Calculator(-6, -3, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void DivisionReturnsCorrectResultForPositiveAndNegative()
        {
            var calc = new BYT3_2.Calculator(6, -3, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void DivisionReturnsCorrectResultForDecimalResult()
        {
            var calc = new BYT3_2.Calculator(5, 2, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(2.5));
        }

        [Test]
        public void DivisionByZeroThrowsException()
        {
            var calc = new BYT3_2.Calculator(5, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void AdditionForMaxValuesWorkCorrectly()
        {
            var calc = new BYT3_2.Calculator(double.MaxValue, double.MaxValue, '+');
            Assert.That(double.IsInfinity(calc.Calculate()), Is.True);
        }
        
        [Test]
        public void MultiplicationForMaxValuesWorkCorrectly()
        {
            var calc = new BYT3_2.Calculator(double.MaxValue, double.MaxValue, '*');
            Assert.That(double.IsInfinity(calc.Calculate()), Is.True);
        }
        
        [Test]
        public void InvalidOperatorThrowsException()
        {
            var calc = new BYT3_2.Calculator(5, 5, '%');
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }
        
    }
}