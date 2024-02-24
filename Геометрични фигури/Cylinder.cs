using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за цилиндър
    public class Cylinder:GeometryObject,IObject3D
    {
        //полета за радиус и височина
        private double radius;
        private double h;


        //свойства за радиус и височина
        public double Radius { get { return radius; } set { radius = value; } }
        public double H { get { return h; } set { h = value; } }


        //конструктор
        public Cylinder(string name,double r,double h):base(name)
        {
            Radius = r;
            H = h;
        }


        //метод за повърхнина
        public double CalculateSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + h);
        }


        //метод за обем
        public double CalculateVolume()
        {
            return Math.PI * radius * radius * h;
        }


        //пренаписваме ToString
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} Height - {H} SurafaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
