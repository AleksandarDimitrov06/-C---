using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    //константна операция
    public class ConstantExpression:IArithmeticExpression
    { 
        //поле 
        private int number;

        //конструктор
        public ConstantExpression(int number)
        {
            this.number = number;
        }

        //метод за изчисление
        public int Calculate()
        {
            return number;
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
