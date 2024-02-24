using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за пирамида
    public class Pyramid:GeometryObject,IObject3D
    {

        //брой ъгли
        private int angles;
        public int Angles
        {
            get { return angles; }
            set 
            { 
                //проверяваме броя на ъглите
                if (value == 4 || value == 3) 
                    angles = value; 
                else 
                    throw new Exception("The angles must be 3 or 4"); 
            }
        }

        //полета за страна и височина
        private double a;
        private double h;


        //свойства
        public double A { get { return a; } set { a = value; } }
        public double H { get { return h; } set { h = value; } }


        //конструктор
        public Pyramid(string name,int angles,double a,double h):base (name)
        {
            this.angles = angles;
            this.a = a;
            this.h = h;
        }


        //метод за повърхнина
        public double CalculateSurfaceArea()
        {
            //според броя на ъглите променливата temp ще има различна стойсност и метода ще връща различен резултат

            IObject2D temp;

            if (angles == 3) 
                temp = new Triangle("temp", a, a, a);

            else 
                temp = new Square("temp", a);

            double SideArea = (angles * a * h) / 2;
            return temp.CalculateArea()+SideArea;
        }

        //метод за обем
        public double CalculateVolume()
        {

            //подходът се повтаря като горния метод
            IObject2D temp;
            if (angles == 3) temp = new Triangle("temp", a, a, a);
            else temp = new Square("temp", a);
            return temp.CalculateArea()*h/3;
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" Angles - {Angles} Side - {A} Height - {H} SurfaceArea - {CalculateSurfaceArea()} Volume - {CalculateVolume()}";
        }
    }
}
