using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class ArbitraryPolygon : GeometryObject, IObject2D
    {
        private double[] sides;
        public double[] Sides
        {
            get { return sides; }
            set { this.sides = value; }
        }
        public ArbitraryPolygon(string name, double[] sides):base(name)
        {
            this.Sides = sides;
        }
        public double CalculatePerimeter()
        {
                double perimeter = 0;
                foreach (double length in Sides)
                {
                    perimeter += length;
                }
                return perimeter;          
        }
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
        public override string ToString()
        {
            StringBuilder sides=new StringBuilder();
            foreach(var a in Sides)sides.Append(" - "+a.ToString());
            return base.ToString()+$"Sides{sides}";
        }
    }
}
