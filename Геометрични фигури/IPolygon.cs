using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{
    public interface IPolygon:IObject2D
    {
        double CalculatePerimeter();
        double CalculateArea();
    }
}
