using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за паралелепипед
    public class Parallelepiped:GeometryObject,IObject3D

        //полета за първа страна,втора страна и височина
    {
        private double a;
        private double b;
        private double h;


        //свойства
        public double A {  get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double H { get { return h; } set { h = value; } }


        //конструктор
        public Parallelepiped(string name, double a, double b, double h) : base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }


        //метод за повърхнина
        public double CalculateSurfaceArea()
        {
            return 2 * (A * H + B * H + A * B);
        }


        //метод за обем
        public double CalculateVolume()
        {
            return A * B * H;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" A - {A} B - {B} Height - {H} Area - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
