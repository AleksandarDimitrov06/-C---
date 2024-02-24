using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    //клас за квадрат
    public class Square: GeometryObject,IPolygon
    {
        //поле за страната
        private double a;


        //свойство
        public double A { get { return a; } set {  a = value; } }


        //конструктор
        public Square(string name, double a):base (name)
        {
            this.a = a;
        }


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return 4 * A;
        }


        //метод за лице
        public double CalculateArea()
        {
            return A * A;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" Side - {A} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
