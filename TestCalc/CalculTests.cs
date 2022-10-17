using Xunit;

namespace TestCalc
{
    public class CalculTests
    {
        double a = 10, b = 5;
        [Fact]
        public void Amount()
        {
            var calc = Calc.Compute(a, b, '+');
            Assert.Equal(a + b, calc);
        }

        [Fact]
        public void Subtraction()
        {
            var calc1 = Calc.Compute(a, b, '-');
            Assert.Equal(a - b, calc1);
        }

        [Fact]
        public void Multiplication()
        {
            var calc2 = Calc.Compute(a, b, '*');
            Assert.Equal(a * b, calc2);
        }

        [Fact]
        public void Division()
        {
            var calc3 = Calc.Compute(a, b, '/');
            Assert.Equal(a / b, calc3);
        }
    }
}
