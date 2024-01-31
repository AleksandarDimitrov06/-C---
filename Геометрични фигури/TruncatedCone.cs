using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class TruncatedCone:GeometryObject,IObject3D
    {
        private double r1;
        private double r2;
        private double h;
        private double l;
        public double R1 {  get { return r1; } set {  r1 = value; } }
        public double R2 { get { return r2; } set { r2 = value; } }
        public double H { get { return h; } set { h = value; } }
        public double L { get { return l; } set { l = value; } }
        public TruncatedCone(string name,double r1,double r2,double h,double l) : base(name)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.h = h;
            this.l = l;
        }
        public double CalculateSurfaceArea()
        {
            return Math.PI*(r1+r2)*l+Math.PI*r1*r1 + Math.PI*r2*r2;
        }
        public double CalculateVolume()
        {
            return (Math.PI * H * (r1 * r1 + r2 * r2 + r1 * r2))/3;
        }
        public override string ToString()
        {
            return base.ToString() + $"R1 - {R1} R2 - {R2} H - {H} L - {L} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";  
        }
    }
}
