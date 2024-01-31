using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Геометрични_фигури
{
    public class Sphere : GeometryObject, IObject3D
    {
        private double radius;
        public double Radius { get { return radius; } set { radius = value; } }
        public Sphere(string name, double r) : base(name)
        {
            radius = r;
        }
        public double CalculateSurfaceArea()
        {
            return 4 * Math.PI * radius * radius;
        }
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 3) * 4 / 3;
        }
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
