using System;
using Xunit;

namespace AreaCalculator.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(5, 25)]
        [InlineData(8, 64)]
        [InlineData(6, 33)]
        public void TestArea(int radius, double value)
        {
            Figure circle = new Circle { Radius = radius };

            Assert.Equal(value * Math.PI, circle.Area());
        }
    }
}
