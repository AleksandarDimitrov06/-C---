using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за успоредник
    public class Parallelogram:GeometryObject,IObject2D
    {

        //полета за първа страна,втора страна и височина
        private double a;
        private double b;
        private double h;


        //свойства
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double H { get { return h; } set { h = value; } }


        //конструктор
        public Parallelogram(string name,double a, double b, double h):base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return 2 * a + 2 * b;
        }


        //метод за лице
        public double CalculateArea()
        {
            return a * h;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} height - {H} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
