using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рационални_числа
{
    public struct Racional
    {
        public int Numerator;
        public int Denominator;
        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public Racional(int numerator, int denominator)
        {
            int divisor=GreatestCommonDivisor(numerator, denominator);
            Numerator=numerator/divisor;
            Denominator=denominator/divisor;
        }
        public static Racional operator +(Racional n1,Racional n2)
        {
            int numerator = n1.Numerator * n2.Denominator + n2.Numerator * n1.Denominator;
            int denominator = n1.Denominator * n2.Denominator;
            return new Racional(numerator/GreatestCommonDivisor(numerator,denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }
        public static Racional operator -(Racional n1, Racional n2)
        {
            int numerator = n1.Numerator * n2.Denominator - n2.Numerator * n1.Denominator;
            int denominator = n1.Denominator * n2.Denominator;
            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }
        public static Racional operator *(Racional n1, Racional n2)
        {
            int numerator = n1.Numerator * n2.Numerator;
            int denominator = n1.Denominator * n2.Denominator;
            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }
        public static Racional operator /(Racional n1, Racional n2)
        {
            if (n2.Numerator == 0) throw new DivideByZeroException("Cannot divide by zero.");
            int numerator = n1.Numerator * n2.Denominator;
            int denominator = n1.Denominator * n2.Numerator;
            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }
        public static implicit operator Racional(int number)
        {
            return new Racional(number, 1);
        }
        public static explicit operator int(Racional n)
        {
            return n.Numerator/n.Denominator;
        }
        public static implicit operator float(Racional rational)
        {
            return (float)rational.Numerator / rational.Denominator;
        }
        public static implicit operator double(Racional rational)
        {
            return (double)rational.Numerator / rational.Denominator;
        }
        public static implicit operator decimal(Racional rational)
        {
            return (decimal)rational.Numerator / rational.Denominator;
        }
        public Racional Reciprocal()
        {
            return new Racional(Denominator, Numerator);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
