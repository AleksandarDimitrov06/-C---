using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //клас за линия
    public class Line:GeometryObject
    {

        //полета за начална точка и крайна точка
        private Point startPoint;
        private Point endPoint;

        //свойство за начална точка
        public Point StartPoint {  get { return startPoint; } set {  startPoint = value; } }

        //свойство за крайна точка
        public Point EndPoint { get { return endPoint; } set {  endPoint = value; } }


        //конструктор
        public Line(string name,Point start,Point end):base (name)
        {
            this.startPoint = start;
            this.endPoint = end;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" StartPoint - {StartPoint} EndPoint - {EndPoint}";
        }
    }
}
