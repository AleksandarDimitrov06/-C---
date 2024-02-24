using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за трапец
    public class Trapezoid:GeometryObject,IObject2D
    {

        //полета за 4те страни и височина
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;


        //свойства
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }
        public double D { get { return d; } set { d = value; } }
        public double H { get { return h; }set { h = value; } }


        //конструктор
        public Trapezoid(string name,double a,double b,double c,double d,double h):base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            H = h;
        } 


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return a + c + b + d;
        }


        //метод за лице
        public double CalculateArea()
        {
            return ((a + b) * h) / 2;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} C - {C} D - {D} H - {H} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
