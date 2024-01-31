using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Square: GeometryObject,IPolygon
    {
        private double a;
        public double A { get { return a; } set {  a = value; } }
        public Square(string name, double a):base (name)
        {
            this.a = a;
        }
        public double CalculatePerimeter()
        {
            return 4 * A;
        }
        public double CalculateArea()
        {
            return A * A;
        }
        public override string ToString()
        {
            return base.ToString() + $" Side - {A} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
