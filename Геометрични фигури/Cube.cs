using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за куб
    public class Cube:GeometryObject,IObject3D
    {

        //поле за страната
        private double side;

        //свойство за страната
        public double Side {  get { return side; } set {  side = value; } }


        //конструктор
        public Cube(string name,double a):base (name)
        {
            this.side = a;
        }


        //метод за повърхнина
        public double CalculateSurfaceArea()
        {
            return 6*Math.Pow(Side,2);
        }


        //метод за обем
        public double CalculateVolume()
        {
            return Math.Pow(Side, 3);
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" A - {Side} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
