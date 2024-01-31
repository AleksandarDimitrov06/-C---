using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Parallelepiped:GeometryObject,IObject3D
    {
        private double a;
        private double b;
        private double h;
        public double A {  get { return a; } set {  a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double H { get { return h; } set { h = value; } }
        public Parallelepiped(string name, double a, double b, double h) : base(name)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public double CalculateSurfaceArea()
        {
            return 2 * (A * H + B * H + A * B);
        }
        public double CalculateVolume()
        {
            return A * B * H;
        }
        public override string ToString()
        {
            return base.ToString() + $" A - {A} B - {B} Height - {H} Area - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
