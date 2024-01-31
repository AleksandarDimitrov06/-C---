using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Point:GeometryObject
    {
        private double x;
        private double y;
        public double X { get { return x; } set {  x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public Point(string name, double x, double y):base (name)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return base.ToString() + $" X - {X} Y - {Y}";
        }
    }
}
