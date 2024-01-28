using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Аритметични_изрази
{
    public class ConstantExpression:IArithmeticExpression
    { 
        private int number;
        public ConstantExpression(int number)
        {
            this.number = number;
        }
        public int Calculate()
        {
            return number;
        }
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
