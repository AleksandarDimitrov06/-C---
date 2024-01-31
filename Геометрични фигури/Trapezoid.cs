using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Trapezoid:GeometryObject,IObject2D
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }
        public double D { get { return d; } set { d = value; } }
        public double H { get { return h; }set { h = value; } }
        public Trapezoid(string name,double a,double b,double c,double d,double h):base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            H = h;
        } 
        public double CalculatePerimeter()
        {
            return a + c + b + d;
        }
        public double CalculateArea()
        {
            return ((a + b) * h) / 2;
        }
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} C - {C} D - {D} H - {H} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
