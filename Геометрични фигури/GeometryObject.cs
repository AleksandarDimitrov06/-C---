using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    //клас за геометричен обект
    public class GeometryObject
    {
        //поле за име
        private string name;


        //свойство за име
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //конструктор
        public GeometryObject(string name)
        {
            this.name = name;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"Name - {Name}";
        }
    }
}
