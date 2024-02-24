using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за произволен многоъгълник
    public class ArbitraryPolygon : GeometryObject, IObject2D
    {
        //поле за страните, които ще се съхраняват в масив
        private double[] sides;


        //свойство за страните
        public double[] Sides
        {
            get { return sides; }
            set { this.sides = value; }
        }


        //конструктор
        public ArbitraryPolygon(string name, double[] sides):base(name)
        {
            this.Sides = sides;
        }


        //метод за изчисляване на обиколка
        public double CalculatePerimeter()
        {
                double perimeter = 0;
                foreach (double length in Sides)
                {
                    perimeter += length;
                }
                return perimeter;          
        }


        //метод за изчисляване на лице
        public double CalculateArea()
        {
            double area = 0;
            int j = Sides.Length - 1;

            for (int i = 0; i < Sides.Length; i++)
            {
                area += (Sides[j] + Sides[i]) * (Sides[j] - Sides[i]);
                j = i;
            }
            return Math.Abs(area / 2);
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            StringBuilder sides=new StringBuilder();
            foreach(var a in Sides)sides.Append(" - "+a.ToString());
            return base.ToString()+$"Sides{sides}";
        }
    }
}
