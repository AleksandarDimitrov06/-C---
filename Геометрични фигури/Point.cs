using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за точка
    public class Point:GeometryObject
    {
        //полета за координатите x и y
        private double x;
        private double y;


        //свойства
        public double X { get { return x; } set {  x = value; } }
        public double Y { get { return y; } set { y = value; } }


        //конструктор
        public Point(string name, double x, double y):base (name)
        {
            this.X = x;
            this.Y = y;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString() + $" X - {X} Y - {Y}";
        }
    }
}
