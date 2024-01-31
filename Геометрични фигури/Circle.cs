using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Circle:GeometryObject,IRoundShape
    {
        private double radius;
        public double Radius {  get { return radius; } set {  radius = value; } }
        public Circle(string name,double radius):base (name)
        {
            Radius = radius;
        }
        public double CalculatePerimeter()
        {
            return 2*Math.PI*radius;
        }
        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
        public override string ToString()
        {
            return base.ToString() + $" Radius - {Radius} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
