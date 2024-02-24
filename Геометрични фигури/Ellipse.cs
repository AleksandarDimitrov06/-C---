using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{


    //клас за Елипса
    public class Ellipse:GeometryObject,IRoundShape
    {


        //полета за голям и малък радиус
        private double bigRadius;
        private double smallRadius;


        //свойства
        public double BigRadius {  get { return bigRadius; } set {  bigRadius = value; } }
        public double SmallRadius { get { return smallRadius; } set {  smallRadius = value; } }


        //конструктор
        public Ellipse(string name,double r1,double r2) : base(name)
        {
            this.bigRadius = r1;
            this.smallRadius = r2;
        }


        //метод за лице
        public double CalculateArea()
        {
            return Math.PI * SmallRadius * BigRadius;
        }


        //метод за обиколка
        public double CalculatePerimeter()
        {
            return Math.PI*(1.5*(smallRadius+bigRadius)-Math.Sqrt(bigRadius-smallRadius));
        }


        //пренаписан метод ToString
        public override string ToString()
        {
            return base.ToString() + $"BigRadius - {BigRadius} SmallRadius - {SmallRadius} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
