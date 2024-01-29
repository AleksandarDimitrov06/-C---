using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{
    public class DirectSaleAdvertisement:Advertisement
    {
        public readonly double price;
        public DirectSaleAdvertisement(bool active, DateTime dateofregistration, Item item, User user, double price):base (active, dateofregistration, item, user)
        {
            this.price = price;
        }
        public override string ToString()
        {
            return base.ToString()+$" - {price}";
        }
    }
}
