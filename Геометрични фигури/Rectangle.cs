using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    //клас за правоъгълник
    public class Rectangle:GeometryObject,IPolygon
    {

        //полета за двете страни
        private double a;
        private double b;


        //свойства
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }


        //конструктор
        public Rectangle(string name,double a,double b):base (name)
        {
            this.a = a;
            this.b = b;
        }


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return 2 * A + 2 * B;
        }


        //метод за лице
        public double CalculateArea()
        {
            return A * B;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" A - {A} B - {B} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
