using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Cylinder:GeometryObject,IObject3D
    {
        private double radius;
        private double h;
        public double Radius { get { return radius; } set { radius = value; } }
        public double H { get { return h; } set { h = value; } }
        public Cylinder(string name,double r,double h):base(name)
        {
            Radius = r;
            H = h;
        }
        public double CalculateSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + h);
        }
        public double CalculateVolume()
        {
            return Math.PI * radius * radius * h;
        }
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} Height - {H} SurafaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
