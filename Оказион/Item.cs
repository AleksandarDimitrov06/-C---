using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{

    //клас за артикул
    public class Item
    {

        //полета за името на артикула и цената му
        public readonly string item;
        private readonly double price;

        //конструктор
        public Item(string item,double price) 
        {
            this.item = item;
            this.price = price;           
        }

        //пренаписваме метода ToString
        public override string ToString()
        {
            return $"{item} - {price}";
        }
    }
}
