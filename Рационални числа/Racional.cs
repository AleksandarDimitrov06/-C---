using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рационални_числа
{
    //клас за рационални числа
    public struct Racional
    {
        //полета за числител и знаменател
        public int Numerator;
        public int Denominator;

        //Метод, който да намира най-големия общ делител
        private static int GreatestCommonDivisor(int a, int b)
        {
            //проверяваме дали b не е равно на 0
            while (b != 0)
            {
                //чрез 3та променлива променяме стойностите  
                int temp = b;
                b = a % b;
                a = temp;
            }

            //връщаме новата стойност на а, която ще е най-големия общ делител
            return a;
        }

        //констриктор
        public Racional(int numerator, int denominator)
        {
            //в конструктора директно съкращаваме числата ако е възможно
            int divisor=GreatestCommonDivisor(numerator, denominator);
            Numerator=numerator/divisor;
            Denominator=denominator/divisor;
        }

        //пренаписваме оператора за събиране
        public static Racional operator +(Racional n1,Racional n2)
        {
            //числител
            int numerator = n1.Numerator * n2.Denominator + n2.Numerator * n1.Denominator;

            //знаменател
            int denominator = n1.Denominator * n2.Denominator;

            //връщаме съкратената получена дроб
            return new Racional(numerator/GreatestCommonDivisor(numerator,denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }

        //пренаписваме оператора за изваждане
        public static Racional operator -(Racional n1, Racional n2)
        {   
            //процедурата се повратя само променяме операцията на изваждане
            int numerator = n1.Numerator * n2.Denominator - n2.Numerator * n1.Denominator;     
            int denominator = n1.Denominator * n2.Denominator;
        
            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }

        //пренаписваме оператора за умножение
        public static Racional operator *(Racional n1, Racional n2)
        {
            //процедурата се повратя само променяме операцията на умножение
            int numerator = n1.Numerator * n2.Numerator;
            int denominator = n1.Denominator * n2.Denominator;

            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }

        //пренаписваме оператора за делене
        public static Racional operator /(Racional n1, Racional n2)
        {
            //проверяваме дали знаменателя е 0
            if (n2.Numerator == 0) 
                throw new DivideByZeroException("Cannot divide by zero.");

            //за да получим числител и знаменател умножаваме на кръст
            int numerator = n1.Numerator * n2.Denominator;
            int denominator = n1.Denominator * n2.Numerator;

            //връщаме получените числа като ги съкращаваме
            return new Racional(numerator / GreatestCommonDivisor(numerator, denominator), denominator / GreatestCommonDivisor(numerator, denominator));
        }

        //презаписваме преобразуването на int към racional
        public static implicit operator Racional(int number)
        {
            //връщаме числото със знаменател 1
            return new Racional(number, 1);
        }

        //презаписваме преобразуването на racional към int
        public static explicit operator int(Racional n)
        {
            //делим числител на знаменател
            return n.Numerator/n.Denominator;
        }

        //презаписваме преобразуването на racional към float
        public static implicit operator float(Racional rational)
        {
            //превръщаме числителя в float и го делим на знаменателя
            return (float)rational.Numerator / rational.Denominator;
        }

        //презаписваме преобразуването на racional към double
        public static implicit operator double(Racional rational)
        {
            //превръщаме числителя в double и го делим на знаменателя
            return (double)rational.Numerator / rational.Denominator;
        }

        //презаписваме преобразуването на racional към decimal
        public static implicit operator decimal(Racional rational)
        {
            //превръщаме числителя в decimal и го делим на знаменателя
            return (decimal)rational.Numerator / rational.Denominator;
        }

        //метод за намирането на реципрочната дроб
        public Racional Reciprocal()
        {
            //връщаме реципрочната дроб
            return new Racional(Denominator, Numerator);
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
