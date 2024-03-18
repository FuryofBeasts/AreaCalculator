using System;

namespace AreaCalculator
{
    public class Triangle:Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Area()
        {
            var p = Perimeter() / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            if (A > B && A > C)
            {
                return A * A == B * B + C * C;
            }

            if (B > C && B > A)
            {
                return B * B == A * A + C * C;
            }

            return C * C == A * A + B * B;
        }

        public int Perimeter()
        {
            return A + B + C;
        }
    }
}
