using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за триъгълник
    public class Triangle:GeometryObject,IPolygon
    {

        //полета за 3те страни
        private double a;
        private double b;
        private double c;


        //свойства
        public double A {  get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }


        //конструктор
        public Triangle(string name, double a, double b, double c):base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return a + b + c;
        }



        //метод за лице
        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} C - {C} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
