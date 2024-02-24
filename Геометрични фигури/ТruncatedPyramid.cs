using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{


    //клас за пресечена пирамида
    public class ТruncatedPyramid:GeometryObject,IObject3D
    {

        //полета за две страни на основата, височина на пирамидата и височина на околна страна
        private double a;
        private double b;
        private double h;
        private double k;


        //свойства
        public double A { get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double H { get { return h; } set { h = value; } }
        public double K { get { return k; } set { k = value; } }


        //конструктор
        public ТruncatedPyramid(string name,double a,double b,double h,double k) : base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            this.k = k;
        }


        //метод за повърхнина
        public double CalculateSurfaceArea()
        {
            double B = a * a;
            double B1= b * b;
            return B + B1 + (2 * (a + b) * k);
        }


        //метод за обем
        public double CalculateVolume()
        {
            return (a * a + b * b+Math.Sqrt(a*a*b*b))*H/3;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" A - {A} B - {B} H - {H} K - {K} Area - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
