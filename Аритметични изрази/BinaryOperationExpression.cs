using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    //бинарна операция
    public class BinaryOperationExpression:IArithmeticExpression
    {
        //полета
        private int number1;
        private int number2;
        private char operation;

        //конструктор
        public BinaryOperationExpression(int number1, int number2, char operation)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.operation = operation;
        }

        //метод за изчисляване
        public int Calculate()
        {
            //проверяваме каква е операцията
            switch(operation)
            {
                //събиране
                case '+':
                    return number1+number2;

                //изваждане
                case '-':
                    return number1-number2;

                //умножение
                case '*':
                    return number1*number2;

                //делене
                case '/':
                    return number2/number2;

                //или грешка
                default:
                    throw new Exception("Wrong input!");
            }
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"{number1} {operation} {number2} = {Calculate()}";
        }
    }
}
