using Xunit;

namespace AreaCalculator.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(8, 8, 8, 28)]
        public void TestArea(int a, int b, int c, double value)
        {
            Figure triangle = new Triangle { A = a, B = b, C = c };

            Assert.Equal(value, triangle.Area());
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void TestRectangular(int a, int b, int c)
        {
            Triangle triangle = new Triangle { A = a, B = b, C = c };

            Assert.True(triangle.IsRectangular());
        }
    }
}
