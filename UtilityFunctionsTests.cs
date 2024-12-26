using Xunit;
using Lab2;

namespace Lab2.Tests
{
    public class UtilityFunctionsTests
    {
        [Fact]
        public void TestSin()
        {
            Assert.Equal(0, MathFunctions.Sin(0), 5); 
            Assert.Equal(1, MathFunctions.Sin(Math.PI / 2), 5); 
        }

        [Fact]
        public void TestCos()
        {
            Assert.Equal(1, MathFunctions.Cos(0), 5); 
            Assert.Equal(0, MathFunctions.Cos(Math.PI / 2), 5);
        }

        [Fact]
        public void TestLn()
        {
            Assert.Equal(0, MathFunctions.Ln(1), 5); 
            Assert.Throws<ArgumentException>(() => MathFunctions.Ln(-1)); 
        }

        [Fact]
        public void TestSinPlusCosSquared()
        {
            double x = Math.PI / 4; 
            double sinX = MathFunctions.Sin(x); 
            double cosX = MathFunctions.Cos(x); 
            double result = Math.Sqrt(sinX + Math.Pow(cosX, 2));
            double expected = 1.0987;
            double tolerance = 1e-4;
            Assert.True(Math.Abs(result - expected) < tolerance);
        }                                                                   

        [Fact]
        public void TestSinMinusCosAbsolute()
        {
            double x = Math.PI / 4;
            double sinX = MathFunctions.Sin(x);
            double cosX = MathFunctions.Cos(x);
            double result = Math.Abs(sinX - cosX);
            Assert.True(result >= 0); 
        }
    }
}
