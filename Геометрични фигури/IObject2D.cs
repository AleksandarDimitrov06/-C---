﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Геометрични_фигури
{

    //интерфейс за обект 2D
    public interface IObject2D
    {

        //метод за обиколка
        double CalculatePerimeter();


        //метод за лице
        double CalculateArea();
    }
}
