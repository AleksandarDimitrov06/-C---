using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class Line:GeometryObject
    {
        private double startPoint;
        private double endPoint;
        public double StartPoint {  get { return startPoint; } set {  startPoint = value; } }
        public double EndPoint { get { return endPoint; } set {  endPoint = value; } }
        public Line(string name,double start,double end):base (name)
        {
            this.startPoint = start;
            this.endPoint = end;
        }
        public override string ToString()
        {
            return base.ToString()+$" StartPoint - {StartPoint} EndPoint - {EndPoint}";
        }
    }
}
