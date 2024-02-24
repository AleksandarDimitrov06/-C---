using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //интерфейс за обект 3D
    public interface IObject3D
    {

        //метод за повърхнина
        double CalculateSurfaceArea();


        //метод за обем
        double CalculateVolume();
    }
}
