using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Rectangle:GeometryObject,IPolygon
    {
        private double a;
        private double b;
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public Rectangle(string name,double a,double b):base (name)
        {
            this.a = a;
            this.b = b;
        }
        public double CalculatePerimeter()
        {
            return 2 * A + 2 * B;
        }
        public double CalculateArea()
        {
            return A * B;
        }
        public override string ToString()
        {
            return base.ToString() + $" A - {A} B - {B} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
