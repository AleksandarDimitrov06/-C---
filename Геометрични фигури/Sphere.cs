using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Геометрични_фигури
{

    //клас за сфера
    public class Sphere : GeometryObject, IObject3D
    {

        //поле за радиус
        private double radius;


        //свойство
        public double Radius { get { return radius; } set { radius = value; } }


        //конструктор
        public Sphere(string name, double r) : base(name)
        {
            radius = r;
        }


        //метод за повърхност
        public double CalculateSurfaceArea()
        {
            return 4 * Math.PI * radius * radius;
        }

        //метод за обем
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 3) * 4 / 3;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" Radius - {Radius} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
