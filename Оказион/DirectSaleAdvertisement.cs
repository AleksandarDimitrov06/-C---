using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оказион
{

    //клас за директно закупуване на артикул
    public class DirectSaleAdvertisement:Advertisement
    {

        //поле за цена
        public readonly double price;


        //конструктор
        public DirectSaleAdvertisement(bool active, DateTime dateofregistration, Item item, User user, double price):base (active, dateofregistration, item, user)
        {
            this.price = price;
        }


        //пренаписваме метода ToString
        public override string ToString()
        {
            return base.ToString()+$" - {price}";
        }
    }
}
