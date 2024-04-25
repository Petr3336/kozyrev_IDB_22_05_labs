
namespace ConsoleApp2
{
    public class RationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        public override string ToString()
        {
            return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
        }

        public void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;
            if (Numerator < 0 && Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator,
                                      r1.Denominator * r2.Denominator);
        }
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator,
                                      r1.Denominator * r2.Denominator);
        }

        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator == r2.Numerator * r1.Denominator;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator != r2.Numerator * r1.Denominator;
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator <= r2.Numerator * r1.Denominator;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator >= r2.Numerator * r1.Denominator;
        }
    }

}