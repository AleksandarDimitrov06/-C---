using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Cone:GeometryObject,IObject3D
    {
        private double radius;
        private double h;
        private double l;
        public double Radius {  get { return radius; } set {  radius = value; } }
        public double H { get { return h; } set { h = value; } }
        public Cone(string name, double radius, double h):base (name)
        {
            Radius = radius;
            H= h;
            l=Math.Sqrt(radius*radius+h*h);
        }
        public double CalculateSurfaceArea()
        {
            return Math.PI * radius * (radius + l);
        }
        public double CalculateVolume()
        {
            return Math.PI * radius * radius * h / 3;
        }
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} Height - {H} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
