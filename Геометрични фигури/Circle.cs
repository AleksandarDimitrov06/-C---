using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    //клас за кръг
    public class Circle:GeometryObject,IRoundShape
    {
        //поле за радиус
        private double radius;


        //свойство за радиус
        public double Radius {  get { return radius; } set {  radius = value; } }

        //конструктор
        public Circle(string name,double radius):base (name)
        {
            Radius = radius;
        }


        //метод за изчисляване на периметър
        public double CalculatePerimeter()
        {
            return 2*Math.PI*radius;
        }


        //метод аз изчисляване на лице
        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius,2);
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" Radius - {Radius} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
