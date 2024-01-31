using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Ellipse:GeometryObject,IRoundShape
    {
        private double bigRadius;
        private double smallRadius;
        public double BigRadius {  get { return bigRadius; } set {  bigRadius = value; } }
        public double SmallRadius { get { return smallRadius; } set {  smallRadius = value; } }
        public Ellipse(string name,double r1,double r2) : base(name)
        {
            this.bigRadius = r1;
            this.smallRadius = r2;
        }
        public double CalculateArea()
        {
            return Math.PI * SmallRadius * BigRadius;
        }
        public double CalculatePerimeter()
        {
            return Math.PI*(1.5*(smallRadius+bigRadius)-Math.Sqrt(bigRadius-smallRadius));
        }
        public override string ToString()
        {
            return base.ToString() + $"BigRadius - {BigRadius} SmallRadius - {SmallRadius} Perimeter - {CalculatePerimeter()} Area - {CalculateArea()}";
        }
    }
}
