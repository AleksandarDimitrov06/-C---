using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    public class UnaryOperationExpression: IArithmeticExpression
    {
        private int number;
        public UnaryOperationExpression(int num)
        {
            number = num;
        }
        public int Calculate()
        {
            return (-1)*number;           
        }
        public override string ToString()
        {
            return $"The opposite of {number} is {Calculate()}";
        }
    }
}
