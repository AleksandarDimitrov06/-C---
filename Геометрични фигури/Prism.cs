using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Prism:GeometryObject,IObject3D
    {
        private int angles;
        public int Angles
        {
            get { return angles; }
            set { if (value == 4 || value == 3) angles = value; else throw new Exception("The angles must be 3 or 4"); }
        }
        private double a;
        private double h;
        public double A { get { return a; } set { a = value; } }
        public double H { get { return h; } set { h = value; } }
        public Prism(string name,int angles,double a,double h):base(name)
        {
            this.angles = angles;
            this.A = a;
            this.h = h;
        }
        public double CalculateSurfaceArea()
        {
            IObject2D temp;
            if (angles == 3) temp = new Triangle("temp", a, a, a);
            else temp = new Square("temp", a);
            double SideArea = (angles * a * h) / 2;
            return 2*temp.CalculateArea() + SideArea;
        }
        public double CalculateVolume()
        {
            IObject2D temp;
            if (angles == 3) temp = new Triangle("temp", a, a, a);
            else temp = new Square("temp", a);
            return temp.CalculateArea() * H;
        }
        public override string ToString()
        {
            return base.ToString()+$" Angles - {Angles} Side - {A} Height - {H} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
