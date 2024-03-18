using System;

namespace AreaCalculator
{
    public class Circle:Figure
    {
        public int Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
