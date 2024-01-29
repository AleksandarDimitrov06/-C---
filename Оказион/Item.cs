using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
    public class Item
    {
        public readonly string item;
        private readonly double price;
        public Item(string item,double price) 
        {
            this.item = item;
            this.price = price;           
        }
        public override string ToString()
        {
            return $"{item} - {price}";
        }
    }
}
