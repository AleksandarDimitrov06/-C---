using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    public class BinaryOperationExpression:IArithmeticExpression
    {
        private int number1;
        private int number2;
        private char operation;
        public BinaryOperationExpression(int number1, int number2, char operation)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.operation = operation;
        }
        public int Calculate()
        {
            switch(operation)
            {
                case '+':
                    return number1+number2;
                case '-':
                    return number1-number2;
                case '*':
                    return number1*number2;
                case '/':
                    return number2/number2;
                default:throw new Exception("Wrong input!");
            }
        }
        public override string ToString()
        {
            return $"{number1} {operation} {number2} = {Calculate()}";
        }
    }
}
