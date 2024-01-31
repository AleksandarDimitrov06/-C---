using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Cube:GeometryObject,IObject3D
    {
        private double a;
        public double A {  get { return a; } set {  a = value; } }
        public Cube(string name,double a):base (name)
        {
            this.a = a;
        }
        public double CalculateSurfaceArea()
        {
            return 6*Math.Pow(A,2);
        }
        public double CalculateVolume()
        {
            return Math.Pow(A, 3);
        }
        public override string ToString()
        {
            return base.ToString()+$" A - {A} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
