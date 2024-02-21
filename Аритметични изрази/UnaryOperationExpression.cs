using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    //унарна операция
    public class UnaryOperationExpression: IArithmeticExpression
    {
        //поле
        private int number;

        //конструктор
        public UnaryOperationExpression(int num)
        {
            number = num;
        }

        //метод за изчисление
        public int Calculate()
        {
            return (-1)*number;           
        }

        //пренаписваме ToString
        public override string ToString()
        {
            return $"The opposite of {number} is {Calculate()}";
        }
    }
}
