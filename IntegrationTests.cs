using Xunit;
using Lab2;

namespace Lab2.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public void TestComputeFunctionPositiveX()
        {
            double x = 2.0; 
            double result = MathFunctions.ComputeFunction(x);
            Assert.True(result > 0); 
        }

        [Fact]
        public void TestComputeFunctionNegativeX()
        {
            double x = -2.0; 
            double result = MathFunctions.ComputeFunction(x);
            Assert.True(result > 0); 
        }
    }
}
