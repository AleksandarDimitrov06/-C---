using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Parallelogram:GeometryObject,IObject2D
    {
        private double a;
        private double b;
        private double h;
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double H { get { return h; } set { h = value; } }
        public Parallelogram(string name,double a, double b, double h):base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public double CalculatePerimeter()
        {
            return 2 * a + 2 * b;
        }
        public double CalculateArea()
        {
            return a * h;
        }
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} height - {H} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
