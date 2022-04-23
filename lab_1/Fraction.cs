using System;


namespace lab_1
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        private int num;
        private int den;
        
        public int numerator { get => num; }
        public int denominator { get => den; }

        /// <summary>
        /// Creates a fraction initialized with 0.
        /// </summary>
        public Fraction()
        {

        }

        /// <summary>
        /// Creates a fraction initialized with the given numerator and denominator.
        /// </summary>
        /// <param name="Numerator">The numerator</param>
        /// <param name="Denominator">The denominator</param>
        public Fraction(int Numerator, int Denominator)
        {
            if (Denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(Denominator));
            }
            num = Numerator;
            den = Denominator;
        }

        /// <summary>
        /// Creates a copy of the passed fraction.
        /// </summary>
        /// <param name="previousUlamek">The copied fraction</param>
        public Fraction(Fraction previousUlamek)
        {
            num = previousUlamek.num;
            den = previousUlamek.den;
        }

        /// <summary>
        /// Presents fraction as a string.
        /// </summary>
        /// <returns>A string presentation of the fraction in the form "numerator/denominator".</returns>
        public override string ToString()
        {
            return $"{num} / {den}";
        }

        /// <summary>
        /// Checks whether this fraction is equal to other one.
        /// </summary>
        /// <param name="other">The other fraction</param>
        /// <returns>true or false</returns>
        public bool Equals(Fraction other)
        {
            return den == other.den && num == other.num;
        }

        public static Fraction operator -(Fraction a) => new(-a.num, a.den);

        /// <summary>
        /// Adds two fractions together. The resulting fraction will be improper.
        /// </summary>
        /// <param name="a">The first fraction to add</param>
        /// <param name="b">The second fraction to add</param>
        /// <returns>The result of the mathematical operation.</returns>
        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

        /// <summary>
        /// Subtracts two fractions from each other. The resulting fraction will be improper.
        /// </summary>
        /// <param name="a">The first fraction to subtract from</param>
        /// <param name="b">The second fraction being subtracted</param>
        /// <returns>The result of the mathematical operation.</returns>
        public static Fraction operator -(Fraction a, Fraction b)
            => a - b;

        /// <summary>
        /// Multiplies two fractions
        /// </summary>
        /// <param name="a">The first fraction to multiply</param>
        /// <param name="b">The second fraction to multiply</param>
        /// <returns>The result of the mathematical operation.</returns>
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);

        /// <summary>
        /// Divides two fractions.
        /// </summary>
        /// <param name="a">The first fraction to divide</param>
        /// <param name="b">The second fraction to divide by</param>
        /// <returns>The result of the mathematical operation.</returns>
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }

        /// <summary>
        /// Rounds the fraction to a lower int.
        /// </summary>
        /// <returns>The rounded fraction.</returns>
        public int ToIntFloor()
        {
            return (int)(num / den);
        }

        /// <summary>
        /// Rounds the fraction to the next int.
        /// </summary>
        /// <returns>The rounded fraction.</returns>
        public int ToIntCeil()
        {
            return (int)Math.Ceiling((double)num / (double)den);
        }

        /// <summary>
        /// Compares this object to other Ulamek
        /// </summary>
        /// <param name="u">Ulamek to be compared to</param>
        /// <returns>1 if greater, 0 if equal and -1 if lesser</returns>
        public int CompareTo(Fraction other)
        {
            if (num == other.num)
            {
                if (den > other.den)
                {
                    return -1;
                }
                else if (den < other.den)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            if (den == other.den)
            {
                if (num > other.num)
                {
                    return 1;
                }
                else if (num < other.num)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Fraction temp = new Fraction(num * other.den, den * other.den);
                Fraction temp2 = new Fraction(other.num * den, other.den * den);

                if (temp.num > temp2.num)
                {
                    return 1;
                }
                else if (temp.num < temp2.num)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double Result()
        {
            return num / den;
        }

        public double Multiple(int a, int b)
        {
            return (num / den) * (a / b);
        }
    }
}
