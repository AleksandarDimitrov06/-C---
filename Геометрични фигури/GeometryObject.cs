using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public class GeometryObject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public GeometryObject(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Name - {Name}";
        }
    }
}
