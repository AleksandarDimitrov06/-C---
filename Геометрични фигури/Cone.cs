using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за конус
    public class Cone:GeometryObject,IObject3D
    {

        //полета за радиус,височина и образуваща на конуса
        private double radius;
        private double h;
        private double l;


        //свойства за радиус и височина
        public double Radius {  get { return radius; } set {  radius = value; } }
        public double H { get { return h; } set { h = value; } }


        //конструктор
        public Cone(string name, double radius, double h):base (name)
        {
            Radius = radius;
            H= h;
            l=Math.Sqrt(radius*radius+h*h);
        }


        //метод за намиране на повърхнината 
        public double CalculateSurfaceArea()
        {
            return Math.PI * radius * (radius + l);
        }


        //метод за намиране на обема
        public double CalculateVolume()
        {
            return Math.PI * radius * radius * h / 3;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} Height - {H} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
