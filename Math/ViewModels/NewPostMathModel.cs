using System;

namespace math.MathModels
{
    public class NewPostMathModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }


        public void Calculate(out double X1, out double X2)
        {
            double inside = (B * B) - 4 * A * C;

            if (inside < 0)
            {
                X1 = double.NaN;
                X2 = double.NaN;
            }
            else
            {
                double eqn = (inside);
                X1 = (-B + eqn) / (2 * A);
                X2 = (-B - eqn) / (2 * A);
            }
        }

    }
}